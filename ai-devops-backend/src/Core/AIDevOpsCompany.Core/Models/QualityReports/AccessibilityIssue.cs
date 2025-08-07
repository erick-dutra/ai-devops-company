namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a specific accessibility issue found during accessibility testing.
    /// </summary>
    public class AccessibilityIssue
    {
        /// <summary>
        /// Unique identifier for the accessibility issue.
        /// </summary>
        public string IssueId { get; set; } = string.Empty;
        
        /// <summary>
        /// Detailed description of the accessibility issue.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        
        /// <summary>
        /// Severity level of the accessibility issue.
        /// </summary>
        public AccessibilityIssueSeverity Severity { get; set; }
        
        /// <summary>
        /// The HTML or UI element affected by the accessibility issue.
        /// </summary>
        public string Element { get; set; } = string.Empty;
        
        /// <summary>
        /// Reference to the accessibility guideline that the issue violates.
        /// </summary>
        public string Guideline { get; set; } = string.Empty;
        
        /// <summary>
        /// Suggested action to resolve the accessibility issue.
        /// </summary>
        public string Recommendation { get; set; } = string.Empty;
    }
}
