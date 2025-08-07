namespace AIDevOpsCompany.Core.Interfaces
{
    /// <summary>
    /// Represents a message broker interface for publishing and subscribing to messages.
    /// </summary>
    public interface IMessageBroker
    {
        /// <summary>
        /// Publishes a message asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of the message.</typeparam>
        /// <param name="message">The message to publish.</param>
        Task PublishAsync<T>(T message) where T : class;

        /// <summary>
        /// Subscribes to a queue and handles messages asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of the message.</typeparam>
        /// <param name="queueName">The name of the queue to subscribe to.</param>
        /// <param name="handler">The handler function to process received messages.</param>
        Task SubscribeAsync<T>(string queueName, Func<T, Task> handler) where T : class;

        /// <summary>
        /// Starts the message broker asynchronously.
        /// </summary>
        Task StartAsync();

        /// <summary>
        /// Stops the message broker asynchronously.
        /// </summary>
        Task StopAsync();
    }
}

