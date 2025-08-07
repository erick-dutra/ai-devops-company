namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the severity level of an infrastructure event.
    /// </summary>
    public enum InfrastructureEventSeverity
    {
        /// <summary>
        /// Critical severity event.
        /// </summary>
        Critical,
        /// <summary>
        /// High severity event.
        /// </summary>
        High,
        /// <summary>
        /// Medium severity event.
        /// </summary>
        Medium,
        /// <summary>
        /// Low severity event.
        /// </summary>
        Low,
        /// <summary>
        /// Informational event.
        /// </summary>
        Info
    }
}
