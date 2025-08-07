using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Models.Agents.Messages;
using AIDevOpsCompany.Core.Models.Agents.Tasks;

namespace AIDevOpsCompany.Infrastructure.Messaging
{
    /// <summary>
    /// Background service responsible for subscribing to agent message queues and processing agent messages.
    /// </summary>
    public class MessageProcessingService : BackgroundService
    {
        /// <summary>
        /// Logger for logging service operations.
        /// </summary>
        private readonly ILogger<MessageProcessingService> _logger;

        /// <summary>
        /// Service provider for resolving scoped dependencies.
        /// </summary>
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageProcessingService"/> class.
        /// </summary>
        /// <param name="logger">The logger instance.</param>
        /// <param name="serviceProvider">The service provider for dependency injection.</param>
        public MessageProcessingService(ILogger<MessageProcessingService> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Executes the background service, subscribing to agent queues and processing messages.
        /// </summary>
        /// <param name="stoppingToken">The cancellation token to stop the service.</param>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Message Processing Service started");

            try
            {
                using var scope = _serviceProvider.CreateScope();
                var messageBroker = scope.ServiceProvider.GetRequiredService<IMessageBroker>();
                var messageHandler = scope.ServiceProvider.GetRequiredService<IAgentMessageHandler>();

                // Subscribe to all agent task queues
                await SubscribeToAgentQueues(messageBroker, messageHandler, stoppingToken);

                // Keep the service running
                while (!stoppingToken.IsCancellationRequested)
                {
                    await Task.Delay(1000, stoppingToken);
                }
            }
            catch (OperationCanceledException)
            {
                _logger.LogInformation("Message Processing Service is stopping due to cancellation");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Message Processing Service");
                throw;
            }
        }

        /// <summary>
        /// Subscribes to agent task, event, and notification queues and processes incoming messages.
        /// </summary>
        /// <param name="messageBroker">The message broker for subscribing to queues.</param>
        /// <param name="messageHandler">The handler for processing agent messages.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        private async Task SubscribeToAgentQueues(IMessageBroker messageBroker, IAgentMessageHandler messageHandler, CancellationToken cancellationToken)
        {
            var agentQueues = new[]
            {
                "agent.project-management.tasks",
                "agent.requirements-analysis.tasks",
                "agent.development.tasks",
                "agent.qa.tasks",
                "agent.operations.tasks",
                "agent.devops.tasks",
                "agent.monitoring.tasks",
                "agent.security.tasks",
                "agent.finance.tasks",
                "agent.hr.tasks"
            };

            // Subscribe to task queues
            foreach (var queueName in agentQueues)
            {
                await messageBroker.SubscribeAsync<AgentTask>(queueName, async task =>
                {
                    if (!cancellationToken.IsCancellationRequested)
                    {
                        await messageHandler.HandleTaskMessageAsync(task);
                    }
                });

                _logger.LogInformation("Subscribed to queue: {QueueName}", queueName);
            }

            // Subscribe to event messages
            await messageBroker.SubscribeAsync<AgentMessage>("agent.events.all", async message =>
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    await messageHandler.HandleEventMessageAsync(message);
                }
            });

            // Subscribe to notification messages
            await messageBroker.SubscribeAsync<AgentMessage>("agent.notifications.all", async message =>
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    await messageHandler.HandleNotificationMessageAsync(message);
                }
            });

            _logger.LogInformation("All message subscriptions established");
        }

        /// <summary>
        /// Stops the background service.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Message Processing Service is stopping");
            await base.StopAsync(cancellationToken);
        }
    }
}

