using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using AIDevOpsCompany.Core.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AIDevOpsCompany.Core.Models.Agents.Messages;
using AIDevOpsCompany.Core.Models.Agents.Tasks;

namespace AIDevOpsCompany.Infrastructure.Messaging
{
    /// <summary>
    /// Provides a RabbitMQ-based implementation of the <see cref="IMessageBroker"/> interface for publishing and subscribing to agent messages.
    /// </summary>
    public class RabbitMQMessageBroker : IMessageBroker, IDisposable
    {
        /// <summary>
        /// The RabbitMQ connection instance.
        /// </summary>
        private readonly IConnection _connection;

        /// <summary>
        /// The RabbitMQ channel for communication.
        /// </summary>
        private readonly IModel _channel;

        /// <summary>
        /// Logger for logging broker operations.
        /// </summary>
        private readonly ILogger<RabbitMQMessageBroker> _logger;

        /// <summary>
        /// RabbitMQ configuration settings.
        /// </summary>
        private readonly RabbitMQSettings _settings;

        /// <summary>
        /// Indicates whether the broker has been disposed.
        /// </summary>
        private bool _disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="RabbitMQMessageBroker"/> class.
        /// </summary>
        /// <param name="settings">The RabbitMQ settings.</param>
        /// <param name="logger">The logger instance.</param>
        public RabbitMQMessageBroker(IOptions<RabbitMQSettings> settings, ILogger<RabbitMQMessageBroker> logger)
        {
            _settings = settings.Value;
            _logger = logger;

            try
            {
                var factory = new ConnectionFactory()
                {
                    HostName = _settings.HostName,
                    Port = _settings.Port,
                    UserName = _settings.UserName,
                    Password = _settings.Password,
                    VirtualHost = _settings.VirtualHost,
                    AutomaticRecoveryEnabled = true,
                    NetworkRecoveryInterval = TimeSpan.FromSeconds(10),
                    RequestedHeartbeat = TimeSpan.FromSeconds(60)
                };

                _connection = factory.CreateConnection("AIDevOpsCompany");
                _channel = _connection.CreateModel();

                // Declare exchanges
                DeclareExchanges();

                _logger.LogInformation("RabbitMQ connection established successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to establish RabbitMQ connection");
                throw;
            }
        }

        /// <summary>
        /// Publishes a message to the appropriate RabbitMQ exchange.
        /// </summary>
        /// <typeparam name="T">The type of the message.</typeparam>
        /// <param name="message">The message to publish.</param>
        public async Task PublishAsync<T>(T message) where T : class
        {
            try
            {
                var messageBody = JsonSerializer.Serialize(message);
                var body = Encoding.UTF8.GetBytes(messageBody);

                var properties = _channel.CreateBasicProperties();
                properties.Persistent = true;
                properties.MessageId = Guid.NewGuid().ToString();
                properties.Timestamp = new AmqpTimestamp(DateTimeOffset.UtcNow.ToUnixTimeSeconds());
                properties.ContentType = "application/json";
                properties.Type = typeof(T).Name;

                // Determine exchange and routing key based on message type
                var (exchange, routingKey) = GetExchangeAndRoutingKey(typeof(T));

                _channel.BasicPublish(
                    exchange: exchange,
                    routingKey: routingKey,
                    basicProperties: properties,
                    body: body);

                _logger.LogDebug("Published message to exchange {Exchange} with routing key {RoutingKey}", 
                    exchange, routingKey);

                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to publish message of type {MessageType}", typeof(T).Name);
                throw;
            }
        }

        /// <summary>
        /// Subscribes to a RabbitMQ queue and processes messages using the provided handler.
        /// </summary>
        /// <typeparam name="T">The type of the message.</typeparam>
        /// <param name="queueName">The name of the queue to subscribe to.</param>
        /// <param name="handler">The handler to process received messages.</param>
        public async Task SubscribeAsync<T>(string queueName, Func<T, Task> handler) where T : class
        {
            try
            {
                // Declare queue if it doesn't exist
                _channel.QueueDeclare(
                    queue: queueName,
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                // Set QoS to process one message at a time
                _channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

                var consumer = new EventingBasicConsumer(_channel);
                consumer.Received += async (model, ea) =>
                {
                    try
                    {
                        var body = ea.Body.ToArray();
                        var messageJson = Encoding.UTF8.GetString(body);
                        var message = JsonSerializer.Deserialize<T>(messageJson);

                        if (message != null)
                        {
                            await handler(message);
                            _channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                            
                            _logger.LogDebug("Successfully processed message from queue {QueueName}", queueName);
                        }
                        else
                        {
                            _logger.LogWarning("Failed to deserialize message from queue {QueueName}", queueName);
                            _channel.BasicNack(deliveryTag: ea.DeliveryTag, multiple: false, requeue: false);
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error processing message from queue {QueueName}", queueName);
                        
                        // Reject message and send to dead letter queue
                        _channel.BasicNack(deliveryTag: ea.DeliveryTag, multiple: false, requeue: false);
                    }
                };

                _channel.BasicConsume(queue: queueName, autoAck: false, consumer: consumer);

                _logger.LogInformation("Subscribed to queue {QueueName} for message type {MessageType}", 
                    queueName, typeof(T).Name);

                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to subscribe to queue {QueueName}", queueName);
                throw;
            }
        }

        /// <summary>
        /// Starts the RabbitMQ message broker.
        /// </summary>
        public async Task StartAsync()
        {
            _logger.LogInformation("RabbitMQ Message Broker started");
            await Task.CompletedTask;
        }

        /// <summary>
        /// Stops the RabbitMQ message broker and disposes resources.
        /// </summary>
        public async Task StopAsync()
        {
            Dispose();
            _logger.LogInformation("RabbitMQ Message Broker stopped");
            await Task.CompletedTask;
        }

        /// <summary>
        /// Declares the necessary RabbitMQ exchanges for agent messaging.
        /// </summary>
        private void DeclareExchanges()
        {
            // Task exchange for routing tasks to specific agents
            _channel.ExchangeDeclare(
                exchange: "agent.tasks",
                type: ExchangeType.Topic,
                durable: true,
                autoDelete: false);

            // Event exchange for agent events
            _channel.ExchangeDeclare(
                exchange: "agent.events",
                type: ExchangeType.Topic,
                durable: true,
                autoDelete: false);

            // Notification exchange for broadcasting
            _channel.ExchangeDeclare(
                exchange: "agent.notifications",
                type: ExchangeType.Fanout,
                durable: true,
                autoDelete: false);

            _logger.LogInformation("RabbitMQ exchanges declared successfully");
        }

        /// <summary>
        /// Determines the exchange and routing key for a given message type.
        /// </summary>
        /// <param name="messageType">The type of the message.</param>
        /// <returns>A tuple containing the exchange and routing key.</returns>
        private (string exchange, string routingKey) GetExchangeAndRoutingKey(Type messageType)
        {
            return messageType.Name switch
            {
                nameof(AgentTask) => ("agent.tasks", "task.general"),
                nameof(AgentMessage) => ("agent.events", "event.general"),
                _ => ("agent.events", "general.message")
            };
        }

        /// <summary>
        /// Disposes the RabbitMQ connection and channel resources.
        /// </summary>
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    _channel?.Close();
                    _connection?.Close();
                    _channel?.Dispose();
                    _connection?.Dispose();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error disposing RabbitMQ connection");
                }
                finally
                {
                    _disposed = true;
                }
            }
        }
    }

    /// <summary>
    /// Represents configuration settings for connecting to RabbitMQ.
    /// </summary>
    public class RabbitMQSettings
    {
        /// <summary>
        /// The RabbitMQ host name.
        /// </summary>
        public string HostName { get; set; } = "localhost";

        /// <summary>
        /// The RabbitMQ port number.
        /// </summary>
        public int Port { get; set; } = 5672;

        /// <summary>
        /// The RabbitMQ user name.
        /// </summary>
        public string UserName { get; set; } = "guest";

        /// <summary>
        /// The RabbitMQ password.
        /// </summary>
        public string Password { get; set; } = "guest";

        /// <summary>
        /// The RabbitMQ virtual host.
        /// </summary>
        public string VirtualHost { get; set; } = "/";

        /// <summary>
        /// Whether automatic recovery is enabled for the connection.
        /// </summary>
        public bool AutomaticRecoveryEnabled { get; set; } = true;

        /// <summary>
        /// The interval (in seconds) for network recovery attempts.
        /// </summary>
        public int NetworkRecoveryInterval { get; set; } = 10;

        /// <summary>
        /// The requested heartbeat interval (in seconds).
        /// </summary>
        public int RequestedHeartbeat { get; set; } = 60;
    }
}

