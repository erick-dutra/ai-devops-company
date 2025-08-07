namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a log entry for a pipeline step, including message, level, and line number.
    /// </summary>
    public class StepLog
    {
        /// <summary>
        /// Unique identifier for the step log entry.
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
        /// Line number in the step output related to this log.
        /// </summary>
        public int LineNumber { get; set; }
        /// <summary>
        /// Additional properties or metadata for the log entry.
        /// </summary>
        public Dictionary<string, object> Properties { get; set; } = new();
    }
}
