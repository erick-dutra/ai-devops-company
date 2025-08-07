using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace AIDevOpsCompany.Infrastructure.AI
{
    /// <summary>
    /// Provides extension methods for registering Llama-related services in the dependency injection container.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers the Llama client, AI service, and related settings in the service collection.
        /// </summary>
        /// <param name="services">The service collection to add services to.</param>
        /// <param name="configuration">The application configuration.</param>
        /// <returns>The updated service collection.</returns>
        public static IServiceCollection AddLlamaClient(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure LLAMA settings
            services.Configure<LlamaSettings>(configuration.GetSection("LlamaSettings"));

            // Register HTTP client for LLAMA
            services.AddHttpClient<ILlamaClient, LlamaClient>();

            // Register AI service wrapper
            services.AddScoped<IAIService, AIService>();

            return services;
        }
    }
}

