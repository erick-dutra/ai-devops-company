namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the severity levels for performance issues based on their impact.
    /// </summary>
    public enum QualityPerformanceIssueSeverity
    {
        /// <summary>
        /// Issue that severely impacts system performance, causing system-wide slowdowns or failures.
        /// </summary>
        Critical,
        
        /// <summary>
        /// Issue that significantly impacts performance of major system components.
        /// </summary>
        High,
        
        /// <summary>
        /// Issue that moderately impacts performance in specific areas or under specific conditions.
        /// </summary>
        Medium,
        
        /// <summary>
        /// Issue that has minimal impact on overall system performance.
        /// </summary>
        Low
    }
}
