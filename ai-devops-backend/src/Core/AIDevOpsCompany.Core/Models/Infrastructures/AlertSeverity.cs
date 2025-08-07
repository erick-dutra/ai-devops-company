namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the severity level of an alert in the infrastructure monitoring system.
    /// </summary>
    public enum AlertSeverity
    {
        /// <summary>
        /// Indicates a critical severity alert.
        /// </summary>
        Critical,
        /// <summary>
        /// Indicates a high severity alert.
        /// </summary>
        High,
        /// <summary>
        /// Indicates a medium severity alert.
        /// </summary>
        Medium,
        /// <summary>
        /// Indicates a low severity alert.
        /// </summary>
        Low,
        /// <summary>
        /// Indicates an informational alert.
        /// </summary>
        Info
    }
}
