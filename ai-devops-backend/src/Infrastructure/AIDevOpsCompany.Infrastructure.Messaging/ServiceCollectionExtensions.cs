using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using AIDevOpsCompany.Core.Interfaces;

namespace AIDevOpsCompany.Infrastructure.Messaging
{
    /// <summary>
    /// Provides extension methods for registering RabbitMQ messaging services in the dependency injection container.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers RabbitMQ messaging, message broker, handlers, and background services in the service collection.
        /// </summary>
        /// <param name="services">The service collection to add services to.</param>
        /// <param name="configuration">The application configuration.</param>
        /// <returns>The updated service collection.</returns>
        public static IServiceCollection AddRabbitMQMessaging(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure RabbitMQ settings
            services.AddOptions<RabbitMQSettings>().Configure(options =>
                configuration.GetSection("RabbitMQ"));

            // Register message broker
            services.AddSingleton<IMessageBroker, RabbitMQMessageBroker>();

            // Register message handlers
            services.AddScoped<IAgentMessageHandler, AgentMessageHandler>();

            // Register background services for message processing
            services.AddHostedService<MessageProcessingService>();

            return services;
        }
    }
}

