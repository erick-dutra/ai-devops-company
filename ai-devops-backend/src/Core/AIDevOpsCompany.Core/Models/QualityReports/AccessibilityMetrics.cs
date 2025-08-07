namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents statistical metrics and scores from an accessibility test.
    /// </summary>
    public class AccessibilityMetrics
    {
        /// <summary>
        /// Overall compliance score as a percentage from 0 to 100.
        /// </summary>
        public double ComplianceScore { get; set; }
        
        /// <summary>
        /// Total number of accessibility issues found across all severity levels.
        /// </summary>
        public int TotalIssues { get; set; }
        
        /// <summary>
        /// Number of critical accessibility issues found.
        /// </summary>
        public int CriticalIssues { get; set; }
        
        /// <summary>
        /// Number of major accessibility issues found.
        /// </summary>
        public int MajorIssues { get; set; }
        
        /// <summary>
        /// Number of minor accessibility issues found.
        /// </summary>
        public int MinorIssues { get; set; }
    }
}
