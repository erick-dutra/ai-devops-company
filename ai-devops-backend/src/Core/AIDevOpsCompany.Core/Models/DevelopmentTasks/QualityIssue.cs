namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a quality issue found in code, including type, severity, location, rule, and recommendation.
    /// </summary>
    public class QualityIssue
    {
        /// <summary>
        /// The unique identifier for the quality issue.
        /// </summary>
        public string IssueId { get; set; } = string.Empty;

        /// <summary>
        /// The type of the quality issue.
        /// </summary>
        public QualityIssueType Type { get; set; }

        /// <summary>
        /// The severity of the quality issue.
        /// </summary>
        public QualityIssueSeverity Severity { get; set; }

        /// <summary>
        /// A description of the quality issue.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The name of the file where the issue was found.
        /// </summary>
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// The line number in the file where the issue was found.
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// The rule that was violated.
        /// </summary>
        public string Rule { get; set; } = string.Empty;

        /// <summary>
        /// Recommendation for fixing the issue.
        /// </summary>
        public string Recommendation { get; set; } = string.Empty;

        /// <summary>
        /// The estimated time required to fix the issue.
        /// </summary>
        public TimeSpan EstimatedFixTime { get; set; }
    }
}
