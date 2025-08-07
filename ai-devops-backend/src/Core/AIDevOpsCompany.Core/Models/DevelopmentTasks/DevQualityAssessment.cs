namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a quality assessment for a development artifact, including scores, metrics, issues, and recommendations.
    /// </summary>
    public class DevQualityAssessment
    {
        /// <summary>
        /// The overall quality score for the assessment.
        /// </summary>
        public double OverallScore { get; set; }

        /// <summary>
        /// The code quality metrics for the assessment.
        /// </summary>
        public CodeQualityMetrics QualityMetrics { get; set; } = new();

        /// <summary>
        /// The list of quality issues identified.
        /// </summary>
        public List<QualityIssue> Issues { get; set; } = new();

        /// <summary>
        /// Recommendations for improving quality.
        /// </summary>
        public List<string> Recommendations { get; set; } = new();

        /// <summary>
        /// The date and time when the assessment was performed (UTC).
        /// </summary>
        public DateTime AssessedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The ID of the agent who performed the assessment.
        /// </summary>
        public string AssessedByAgentId { get; set; } = string.Empty;
    }
}
