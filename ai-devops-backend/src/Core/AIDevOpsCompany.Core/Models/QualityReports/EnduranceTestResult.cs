namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents the results of an endurance test that evaluates system stability over an extended period.
    /// </summary>
    public class EnduranceTestResult
    {
        /// <summary>
        /// Name or identifier of the endurance test.
        /// </summary>
        public string TestName { get; set; } = string.Empty;
        
        /// <summary>
        /// Total duration of the endurance test.
        /// </summary>
        public TimeSpan Duration { get; set; }
        
        /// <summary>
        /// Indicates whether a memory leak was detected during the test.
        /// </summary>
        public bool MemoryLeakDetected { get; set; }
        
        /// <summary>
        /// Percentage of performance degradation observed from start to end of the test.
        /// </summary>
        public double PerformanceDegradation { get; set; }
        
        /// <summary>
        /// Collection of resource usage measurements taken at intervals during the test.
        /// </summary>
        public List<ResourceUsageSnapshot> ResourceUsage { get; set; } = new();
    }
}
