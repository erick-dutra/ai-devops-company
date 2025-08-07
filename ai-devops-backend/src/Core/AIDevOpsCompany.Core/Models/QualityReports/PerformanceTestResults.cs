namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents the combined results of various performance tests executed on a software system.
    /// </summary>
    public class PerformanceTestResults
    {
        /// <summary>
        /// Unique identifier for the performance test.
        /// </summary>
        public string TestId { get; set; } = string.Empty;
        
        /// <summary>
        /// Collection of load test results that measure system behavior under expected load.
        /// </summary>
        public List<LoadTestResult> LoadTests { get; set; } = new();
        
        /// <summary>
        /// Collection of stress test results that measure system behavior under extreme conditions.
        /// </summary>
        public List<StressTestResult> StressTests { get; set; } = new();
        
        /// <summary>
        /// Collection of endurance test results that measure system stability over extended periods.
        /// </summary>
        public List<EnduranceTestResult> EnduranceTests { get; set; } = new();
        
        /// <summary>
        /// Aggregated performance metrics from all tests.
        /// </summary>
        public QualityPerformanceMetrics Metrics { get; set; } = new();
        
        /// <summary>
        /// Collection of performance issues identified during testing.
        /// </summary>
        public List<QualityPerformanceIssue> Issues { get; set; } = new();
        
        /// <summary>
        /// Date and time when the performance tests were executed.
        /// </summary>
        public DateTime ExecutedAt { get; set; } = DateTime.UtcNow;
    }
}
