namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the configuration for health checks on infrastructure resources.
    /// </summary>
    public class HealthCheckConfiguration
    {
        /// <summary>
        /// Protocol used for the health check (e.g., HTTP, TCP).
        /// </summary>
        public string Protocol { get; set; } = string.Empty;
        /// <summary>
        /// Port used for the health check.
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// Path to check for HTTP health checks.
        /// </summary>
        public string Path { get; set; } = string.Empty;
        /// <summary>
        /// Interval in seconds between health checks.
        /// </summary>
        public int IntervalSeconds { get; set; }
        /// <summary>
        /// Timeout in seconds for each health check attempt.
        /// </summary>
        public int TimeoutSeconds { get; set; }
        /// <summary>
        /// Number of successful checks before considering healthy.
        /// </summary>
        public int HealthyThreshold { get; set; }
        /// <summary>
        /// Number of failed checks before considering unhealthy.
        /// </summary>
        public int UnhealthyThreshold { get; set; }
    }
}
