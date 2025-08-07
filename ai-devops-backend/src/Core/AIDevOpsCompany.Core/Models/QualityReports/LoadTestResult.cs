namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents the results of a load test that measures system performance under expected user loads.
    /// </summary>
    public class LoadTestResult
    {
        /// <summary>
        /// Name or identifier of the load test.
        /// </summary>
        public string TestName { get; set; } = string.Empty;
        
        /// <summary>
        /// Number of simultaneous users simulated during the test.
        /// </summary>
        public int ConcurrentUsers { get; set; }
        
        /// <summary>
        /// Total duration of the load test.
        /// </summary>
        public TimeSpan Duration { get; set; }
        
        /// <summary>
        /// Average response time across all requests during the test, measured in milliseconds.
        /// </summary>
        public double AverageResponseTime { get; set; }
        
        /// <summary>
        /// Maximum response time observed during the test, measured in milliseconds.
        /// </summary>
        public double MaxResponseTime { get; set; }
        
        /// <summary>
        /// Minimum response time observed during the test, measured in milliseconds.
        /// </summary>
        public double MinResponseTime { get; set; }
        
        /// <summary>
        /// Number of requests processed per second during the test.
        /// </summary>
        public double Throughput { get; set; }
        
        /// <summary>
        /// Percentage of requests that resulted in errors.
        /// </summary>
        public double ErrorRate { get; set; }
        
        /// <summary>
        /// Collection of response time percentiles that show distribution of response times.
        /// </summary>
        public List<ResponseTimePercentile> Percentiles { get; set; } = new();
    }
}
