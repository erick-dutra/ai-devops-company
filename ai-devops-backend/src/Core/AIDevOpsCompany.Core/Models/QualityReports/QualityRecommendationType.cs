namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the categories of quality recommendations based on their focus area.
    /// </summary>
    public enum QualityRecommendationType
    {
        /// <summary>
        /// Recommendations related to improving test coverage.
        /// </summary>
        TestCoverage,
        
        /// <summary>
        /// Recommendations related to improving system performance.
        /// </summary>
        Performance,
        
        /// <summary>
        /// Recommendations related to enhancing security measures.
        /// </summary>
        Security,
        
        /// <summary>
        /// Recommendations related to improving accessibility features.
        /// </summary>
        Accessibility,
        
        /// <summary>
        /// Recommendations related to enhancing code quality and maintainability.
        /// </summary>
        CodeQuality,
        
        /// <summary>
        /// Recommendations related to improving development or operational processes.
        /// </summary>
        Process
    }
}
