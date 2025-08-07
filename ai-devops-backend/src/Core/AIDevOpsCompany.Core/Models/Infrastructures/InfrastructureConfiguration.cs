namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the configuration settings for infrastructure, including scaling, load balancing, and custom options.
    /// </summary>
    public class InfrastructureConfiguration
    {
        /// <summary>
        /// Indicates if high availability is enabled.
        /// </summary>
        public bool HighAvailability { get; set; }
        /// <summary>
        /// Indicates if auto-scaling is enabled.
        /// </summary>
        public bool AutoScaling { get; set; }
        /// <summary>
        /// Minimum number of instances for scaling.
        /// </summary>
        public int MinInstances { get; set; }
        /// <summary>
        /// Maximum number of instances for scaling.
        /// </summary>
        public int MaxInstances { get; set; }
        /// <summary>
        /// Scaling policy configuration.
        /// </summary>
        public ScalingPolicy ScalingPolicy { get; set; } = new();
        /// <summary>
        /// Load balancer configuration.
        /// </summary>
        public LoadBalancerConfiguration LoadBalancer { get; set; } = new();
        /// <summary>
        /// Database configuration.
        /// </summary>
        public DatabaseConfiguration Database { get; set; } = new();
        /// <summary>
        /// Cache configuration.
        /// </summary>
        public CacheConfiguration Cache { get; set; } = new();
        /// <summary>
        /// CDN configuration.
        /// </summary>
        public CDNConfiguration CDN { get; set; } = new();
        /// <summary>
        /// Custom configurations for extensibility.
        /// </summary>
        public Dictionary<string, object> CustomConfigurations { get; set; } = new();
    }
}
