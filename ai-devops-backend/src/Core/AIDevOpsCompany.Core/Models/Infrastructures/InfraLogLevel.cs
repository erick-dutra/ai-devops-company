namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the log level for infrastructure logging.
    /// </summary>
    public enum InfraLogLevel
    {
        /// <summary>
        /// Debug-level logs, used for development and troubleshooting.
        /// </summary>
        Debug,
        /// <summary>
        /// Informational logs.
        /// </summary>
        Info,
        /// <summary>
        /// Warning logs, indicating potential issues.
        /// </summary>
        Warning,
        /// <summary>
        /// Error logs, indicating failures.
        /// </summary>
        Error,
        /// <summary>
        /// Critical logs, indicating severe failures.
        /// </summary>
        Critical
    }
}
