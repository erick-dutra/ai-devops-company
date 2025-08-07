namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the logging configuration for infrastructure resources.
    /// </summary>
    public class LoggingConfiguration
    {
        /// <summary>
        /// Indicates if logging is enabled.
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// Log level for the logs.
        /// </summary>
        public InfraLogLevel LogLevel { get; set; }
        /// <summary>
        /// List of log groups for storing logs.
        /// </summary>
        public List<string> LogGroups { get; set; } = new();
        /// <summary>
        /// Number of days to retain logs.
        /// </summary>
        public int RetentionDays { get; set; }
        /// <summary>
        /// Indicates if structured logging is enabled.
        /// </summary>
        public bool StructuredLogging { get; set; }
        /// <summary>
        /// Format of the logs (e.g., JSON, text).
        /// </summary>
        public string LogFormat { get; set; } = string.Empty;
    }
}
