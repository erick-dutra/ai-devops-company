using AIDevOpsCompany.Core.Models.Requirements;

namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a collection of related test cases grouped for execution and reporting purposes.
    /// </summary>
    public class TestSuite
    {
        /// <summary>
        /// Unique identifier for the test suite.
        /// </summary>
        public string SuiteId { get; set; } = string.Empty;
        
        /// <summary>
        /// Name of the test suite.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// Detailed description of the test suite's purpose and scope.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        
        /// <summary>
        /// Type of testing performed by this test suite (e.g., Unit, Integration, End-to-End).
        /// </summary>
        public TestSuiteType Type { get; set; }
        
        /// <summary>
        /// Collection of test cases included in this test suite.
        /// </summary>
        public List<TestCase> TestCases { get; set; } = new();
        
        /// <summary>
        /// Current execution status of the test suite.
        /// </summary>
        public TestSuiteStatus Status { get; set; } = TestSuiteStatus.Pending;
        
        /// <summary>
        /// Statistical metrics from executing the test suite.
        /// </summary>
        public TestSuiteMetrics Metrics { get; set; } = new();
        
        /// <summary>
        /// Date and time when the test suite was executed.
        /// </summary>
        public DateTime ExecutedAt { get; set; } = DateTime.UtcNow;
        
        /// <summary>
        /// Total time taken to execute the entire test suite.
        /// </summary>
        public TimeSpan ExecutionTime { get; set; }
        
        /// <summary>
        /// Description of the environment where tests were executed (e.g., "Development", "Staging").
        /// </summary>
        public string Environment { get; set; } = string.Empty;
    }
}
