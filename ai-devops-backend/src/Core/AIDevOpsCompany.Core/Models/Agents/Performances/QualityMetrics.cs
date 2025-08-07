namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents quality-related metrics for an agent's performance.
    /// </summary>
    public class QualityMetrics
    {
        /// <summary>
        /// Gets or sets the overall quality score.
        /// </summary>
        public double OverallQualityScore { get; set; }

        /// <summary>
        /// Gets or sets the code quality score.
        /// </summary>
        public double CodeQualityScore { get; set; }

        /// <summary>
        /// Gets or sets the documentation quality score.
        /// </summary>
        public double DocumentationQualityScore { get; set; }

        /// <summary>
        /// Gets or sets the test coverage score.
        /// </summary>
        public double TestCoverageScore { get; set; }

        /// <summary>
        /// Gets or sets the security compliance score.
        /// </summary>
        public double SecurityComplianceScore { get; set; }

        /// <summary>
        /// Gets or sets the best practices adherence score.
        /// </summary>
        public double BestPracticesAdherenceScore { get; set; }

        /// <summary>
        /// Gets or sets the number of quality issues found.
        /// </summary>
        public int QualityIssuesFound { get; set; }

        /// <summary>
        /// Gets or sets the number of quality issues resolved.
        /// </summary>
        public int QualityIssuesResolved { get; set; }

        /// <summary>
        /// Gets or sets the defect density.
        /// </summary>
        public double DefectDensity { get; set; }

        /// <summary>
        /// Gets or sets the customer satisfaction score.
        /// </summary>
        public double CustomerSatisfactionScore { get; set; }

        /// <summary>
        /// Gets or sets the list of quality assessments.
        /// </summary>
        public List<QualityAssessment> Assessments { get; set; } = new();
    }
}
