namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the priority levels for fixing bugs based on business needs.
    /// </summary>
    public enum BugPriority
    {
        /// <summary>
        /// Requires immediate attention, typically blocking critical business operations.
        /// </summary>
        Urgent,
        
        /// <summary>
        /// Should be fixed in the current development cycle.
        /// </summary>
        High,
        
        /// <summary>
        /// Should be addressed soon but not immediately critical.
        /// </summary>
        Medium,
        
        /// <summary>
        /// Can be fixed when time permits, with minimal impact on operations.
        /// </summary>
        Low
    }
}
