namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents the results of an accessibility test conducted on a software application.
    /// </summary>
    public class AccessibilityTestResults
    {
        /// <summary>
        /// Unique identifier for the accessibility test.
        /// </summary>
        public string TestId { get; set; } = string.Empty;
        
        /// <summary>
        /// Collection of accessibility issues found during the test.
        /// </summary>
        public List<AccessibilityIssue> Issues { get; set; } = new();
        
        /// <summary>
        /// Metrics and scores associated with the accessibility test.
        /// </summary>
        public AccessibilityMetrics Metrics { get; set; } = new();
        
        /// <summary>
        /// Collection of accessibility standards used during the test.
        /// </summary>
        public List<AccessibilityStandard> Standards { get; set; } = new();
        
        /// <summary>
        /// Date and time when the accessibility test was executed.
        /// </summary>
        public DateTime ExecutedAt { get; set; } = DateTime.UtcNow;
    }
}
