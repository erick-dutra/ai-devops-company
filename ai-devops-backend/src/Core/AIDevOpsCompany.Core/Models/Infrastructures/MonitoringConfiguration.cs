namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the monitoring configuration for infrastructure resources.
    /// </summary>
    public class MonitoringConfiguration
    {
        /// <summary>
        /// Indicates if monitoring is enabled.
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// List of monitoring metrics.
        /// </summary>
        public List<MonitoringMetric> Metrics { get; set; } = new();
        /// <summary>
        /// List of alert rules for monitoring.
        /// </summary>
        public List<AlertRule> AlertRules { get; set; } = new();
        /// <summary>
        /// URL of the monitoring dashboard.
        /// </summary>
        public string DashboardUrl { get; set; } = string.Empty;
        /// <summary>
        /// Logging configuration for monitoring.
        /// </summary>
        public LoggingConfiguration Logging { get; set; } = new();
    }
}
