namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the configuration for a load balancer, including type, target groups, and SSL settings.
    /// </summary>
    public class LoadBalancerConfiguration
    {
        /// <summary>
        /// Gets or sets the type of load balancer (e.g., Application, Network, Classic).
        /// </summary>
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the list of target groups for the load balancer.
        /// </summary>
        public List<string> TargetGroups { get; set; } = new();
        /// <summary>
        /// Gets or sets the health check configuration for the load balancer.
        /// </summary>
        public HealthCheckConfiguration HealthCheck { get; set; } = new();
        /// <summary>
        /// Gets or sets a value indicating whether SSL termination is enabled.
        /// </summary>
        public bool SslTermination { get; set; }
        /// <summary>
        /// Gets or sets the SSL certificate ID used for SSL termination.
        /// </summary>
        public string SslCertificateId { get; set; } = string.Empty;
    }
}
