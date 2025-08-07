namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a quality report for a project or task.
    /// </summary>
    public class QualityReport
    {
        /// <summary>
        /// Unique identifier for the quality report.
        /// </summary>
        public string ReportId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the related project.
        /// </summary>
        public string ProjectId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the related task.
        /// </summary>
        public string TaskId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the code version tested.
        /// </summary>
        public string CodeVersionId { get; set; } = string.Empty;
        /// <summary>
        /// Type of the quality report.
        /// </summary>
        public QualityReportType ReportType { get; set; }
        /// <summary>
        /// Current status of the quality report.
        /// </summary>
        public QualityReportStatus Status { get; set; } = QualityReportStatus.InProgress;
        /// <summary>
        /// List of test suites executed.
        /// </summary>
        public List<TestSuite> TestSuites { get; set; } = new();
        /// <summary>
        /// List of bugs found during testing.
        /// </summary>
        public List<Bug> BugsFound { get; set; } = new();
        /// <summary>
        /// Quality metrics for the report.
        /// </summary>
        public QualityMetrics Metrics { get; set; } = new();
        /// <summary>
        /// Performance test results.
        /// </summary>
        public PerformanceTestResults PerformanceResults { get; set; } = new();
        /// <summary>
        /// Security test results.
        /// </summary>
        public SecurityTestResults SecurityResults { get; set; } = new();
        /// <summary>
        /// Accessibility test results.
        /// </summary>
        public AccessibilityTestResults AccessibilityResults { get; set; } = new();
        /// <summary>
        /// List of recommendations based on the report.
        /// </summary>
        public List<QualityRecommendation> Recommendations { get; set; } = new();
        /// <summary>
        /// Environment details for the quality report.
        /// </summary>
        public QualityEnvironment Environment { get; set; } = new();
        /// <summary>
        /// Identifier of the agent who executed the report.
        /// </summary>
        public string ExecutedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the report execution started.
        /// </summary>
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date and time when the report execution was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// Total execution time for the report.
        /// </summary>
        public TimeSpan TotalExecutionTime { get; set; }
        /// <summary>
        /// Custom data for extensibility.
        /// </summary>
        public Dictionary<string, object> CustomData { get; set; } = new();
    }
}
