namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the severity levels for bugs based on their impact on the system.
    /// </summary>
    public enum BugSeverity
    {
        /// <summary>
        /// System crash, data loss, or security breach that requires immediate attention.
        /// </summary>
        Critical,
        
        /// <summary>
        /// Major feature is broken, causing significant usability issues.
        /// </summary>
        High,
        
        /// <summary>
        /// Feature works but has noticeable issues that impact user experience.
        /// </summary>
        Medium,
        
        /// <summary>
        /// Minor issue with limited impact on functionality or user experience.
        /// </summary>
        Low
    }
}
