namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines priority levels for implementing quality recommendations.
    /// </summary>
    public enum QualityRecommendationPriority
    {
        /// <summary>
        /// Recommendations that should be implemented immediately to address severe issues.
        /// </summary>
        Critical,
        
        /// <summary>
        /// Important recommendations that should be addressed in the current development cycle.
        /// </summary>
        High,
        
        /// <summary>
        /// Recommendations that should be addressed soon but aren't immediately critical.
        /// </summary>
        Medium,
        
        /// <summary>
        /// Suggestions for improvement that can be implemented when time permits.
        /// </summary>
        Low
    }
}
