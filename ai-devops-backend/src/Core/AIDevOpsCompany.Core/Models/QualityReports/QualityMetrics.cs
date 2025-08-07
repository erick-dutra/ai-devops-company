namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents statistical metrics that measure various aspects of software quality.
    /// </summary>
    public class QualityMetrics
    {
        /// <summary>
        /// Aggregated score representing the overall quality of the software.
        /// </summary>
        public double OverallQualityScore { get; set; }
        
        /// <summary>
        /// Score representing the quality of the source code.
        /// </summary>
        public double CodeQualityScore { get; set; }
        
        /// <summary>
        /// Score representing the quality of documentation.
        /// </summary>
        public double DocumentationQualityScore { get; set; }
        
        /// <summary>
        /// Score representing the level of test coverage.
        /// </summary>
        public double TestCoverageScore { get; set; }
        
        /// <summary>
        /// Score representing the level of security compliance.
        /// </summary>
        public double SecurityComplianceScore { get; set; }
        
        /// <summary>
        /// Score representing the level of adherence to best practices.
        /// </summary>
        public double BestPracticesAdherenceScore { get; set; }
        
        /// <summary>
        /// Total number of quality issues found during testing.
        /// </summary>
        public int QualityIssuesFound { get; set; }
        
        /// <summary>
        /// Number of quality issues that have been resolved.
        /// </summary>
        public int QualityIssuesResolved { get; set; }
        
        /// <summary>
        /// Number of defects per unit of code (typically per 1000 lines of code).
        /// </summary>
        public double DefectDensity { get; set; }
        
        /// <summary>
        /// Score representing customer satisfaction with the software.
        /// </summary>
        public double CustomerSatisfactionScore { get; set; }
        
        /// <summary>
        /// List of quality assessments performed by various agents.
        /// </summary>
        public List<QualityAssessment> Assessments { get; set; } = new();
    }
}
