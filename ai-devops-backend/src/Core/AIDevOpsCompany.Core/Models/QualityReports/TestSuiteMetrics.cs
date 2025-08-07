namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents statistical metrics and performance data from test suite execution.
    /// </summary>
    public class TestSuiteMetrics
    {
        /// <summary>
        /// Total number of tests in the test suite.
        /// </summary>
        public int TotalTests { get; set; }
        
        /// <summary>
        /// Number of tests that passed execution.
        /// </summary>
        public int PassedTests { get; set; }
        
        /// <summary>
        /// Number of tests that failed execution.
        /// </summary>
        public int FailedTests { get; set; }
        
        /// <summary>
        /// Number of tests that were skipped during execution.
        /// </summary>
        public int SkippedTests { get; set; }
        
        /// <summary>
        /// Percentage of tests that passed execution (PassedTests / TotalTests * 100).
        /// </summary>
        public double PassRate { get; set; }
        
        /// <summary>
        /// Total time taken to execute all tests in the suite.
        /// </summary>
        public TimeSpan TotalExecutionTime { get; set; }
        
        /// <summary>
        /// Average time taken to execute a single test in the suite.
        /// </summary>
        public TimeSpan AverageTestTime { get; set; }
    }
}
