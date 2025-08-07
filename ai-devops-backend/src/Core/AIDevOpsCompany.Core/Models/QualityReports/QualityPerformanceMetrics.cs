namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents aggregated performance metrics from various performance tests.
    /// </summary>
    public class QualityPerformanceMetrics
    {
        /// <summary>
        /// Average response time across all tests, measured in milliseconds.
        /// </summary>
        public double AverageResponseTime { get; set; }
        
        /// <summary>
        /// Average number of requests processed per second across all tests.
        /// </summary>
        public double Throughput { get; set; }
        
        /// <summary>
        /// Average percentage of requests that resulted in errors across all tests.
        /// </summary>
        public double ErrorRate { get; set; }
        
        /// <summary>
        /// Average CPU utilization percentage observed during testing.
        /// </summary>
        public double CpuUtilization { get; set; }
        
        /// <summary>
        /// Average memory utilization percentage observed during testing.
        /// </summary>
        public double MemoryUtilization { get; set; }
        
        /// <summary>
        /// Collection of additional custom performance metrics.
        /// </summary>
        public Dictionary<string, object> CustomMetrics { get; set; } = new();
    }
}
