namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents a monitoring metric for infrastructure resources.
    /// </summary>
    public class MonitoringMetric
    {
        /// <summary>
        /// Name of the metric.
        /// </summary>
        public string MetricName { get; set; } = string.Empty;
        /// <summary>
        /// Description of the metric.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Unit of measurement for the metric.
        /// </summary>
        public string Unit { get; set; } = string.Empty;
        /// <summary>
        /// Interval in seconds for metric collection.
        /// </summary>
        public int CollectionIntervalSeconds { get; set; }
        /// <summary>
        /// Indicates if the metric is enabled.
        /// </summary>
        public bool Enabled { get; set; }
    }
}
