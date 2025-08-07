namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents the results of a stress test that pushes the system to its limits to identify its breaking points.
    /// </summary>
    public class StressTestResult
    {
        /// <summary>
        /// Name or identifier of the stress test.
        /// </summary>
        public string TestName { get; set; } = string.Empty;
        
        /// <summary>
        /// Maximum number of concurrent users simulated during the test.
        /// </summary>
        public int MaxUsers { get; set; }
        
        /// <summary>
        /// The number of users or load level at which the system started to fail.
        /// </summary>
        public int BreakingPoint { get; set; }
        
        /// <summary>
        /// Time taken for the system to recover after the stress test, measured in seconds.
        /// </summary>
        public double RecoveryTime { get; set; }
        
        /// <summary>
        /// Description of how the system failed under stress (e.g., crash, timeout, degraded performance).
        /// </summary>
        public string FailureMode { get; set; } = string.Empty;
    }
}
