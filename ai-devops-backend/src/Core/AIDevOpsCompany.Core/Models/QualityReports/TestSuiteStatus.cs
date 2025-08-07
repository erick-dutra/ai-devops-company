namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the possible execution states of a test suite.
    /// </summary>
    public enum TestSuiteStatus
    {
        /// <summary>
        /// Test suite is queued but has not started execution yet.
        /// </summary>
        Pending,
        
        /// <summary>
        /// Test suite is currently executing.
        /// </summary>
        Running,
        
        /// <summary>
        /// Test suite has finished executing, with all tests either passed or failed.
        /// </summary>
        Completed,
        
        /// <summary>
        /// Test suite execution failed due to a critical error before completing all tests.
        /// </summary>
        Failed,
        
        /// <summary>
        /// Test suite execution was manually cancelled before completion.
        /// </summary>
        Cancelled
    }
}
