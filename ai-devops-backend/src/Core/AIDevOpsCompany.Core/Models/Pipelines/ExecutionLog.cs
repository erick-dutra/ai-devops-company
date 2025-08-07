namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a log entry for pipeline execution, including message, level, and context.
    /// </summary>
    public class ExecutionLog
    {
        /// <summary>
        /// Unique identifier for the log entry.
        /// </summary>
        public string LogId { get; set; } = string.Empty;
        /// <summary>
        /// Timestamp when the log entry was created.
        /// </summary>
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Log level (e.g., Info, Warning, Error).
        /// </summary>
        public LogLevel Level { get; set; }
        /// <summary>
        /// Log message content.
        /// </summary>
        public string Message { get; set; } = string.Empty;
        /// <summary>
        /// Source of the log entry (e.g., component or service name).
        /// </summary>
        public string Source { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the pipeline stage related to this log.
        /// </summary>
        public string StageId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the pipeline job related to this log.
        /// </summary>
        public string JobId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the pipeline step related to this log.
        /// </summary>
        public string StepId { get; set; } = string.Empty;
        /// <summary>
        /// Additional properties or metadata for the log entry.
        /// </summary>
        public Dictionary<string, object> Properties { get; set; } = new();
    }
}
