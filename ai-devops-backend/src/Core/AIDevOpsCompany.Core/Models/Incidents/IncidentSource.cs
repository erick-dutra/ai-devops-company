namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents the source of an incident, such as a monitoring system or alert.
    /// </summary>
    public class IncidentSource
    {
        /// <summary>
        /// Gets or sets the type of the incident source.
        /// </summary>
        public IncidentSourceType Type { get; set; }
        /// <summary>
        /// Gets or sets the unique identifier of the source.
        /// </summary>
        public string SourceId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the source.
        /// </summary>
        public string SourceName { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the alert rule that triggered the incident.
        /// </summary>
        public string AlertRule { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the monitoring system.
        /// </summary>
        public string MonitoringSystem { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets additional data related to the source.
        /// </summary>
        public Dictionary<string, object> SourceData { get; set; } = new();
        /// <summary>
        /// Gets or sets the date and time when the incident was detected.
        /// </summary>
        public DateTime DetectedAt { get; set; } = DateTime.UtcNow;
    }
}
