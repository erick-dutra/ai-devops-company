namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a performance issue identified during performance testing.
    /// </summary>
    public class QualityPerformanceIssue
    {
        /// <summary>
        /// Unique identifier for the performance issue.
        /// </summary>
        public string IssueId { get; set; } = string.Empty;
        
        /// <summary>
        /// Type classification of the performance issue.
        /// </summary>
        public QualityPerformanceIssueType Type { get; set; }
        
        /// <summary>
        /// Severity level of the performance issue.
        /// </summary>
        public QualityPerformanceIssueSeverity Severity { get; set; }
        
        /// <summary>
        /// Detailed description of the performance issue.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        
        /// <summary>
        /// Recommended actions to address the performance issue.
        /// </summary>
        public string Recommendation { get; set; } = string.Empty;
        
        /// <summary>
        /// Estimated performance impact percentage (how much the issue degrades performance).
        /// </summary>
        public double Impact { get; set; }
    }
}
