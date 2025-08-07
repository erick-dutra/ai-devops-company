namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the different types of performance issues that can be identified during testing.
    /// </summary>
    public enum QualityPerformanceIssueType
    {
        /// <summary>
        /// Issue related to longer than acceptable response times.
        /// </summary>
        SlowResponse,
        
        /// <summary>
        /// Issue related to excessive CPU utilization.
        /// </summary>
        HighCpuUsage,
        
        /// <summary>
        /// Issue related to progressive memory consumption that isn't released.
        /// </summary>
        MemoryLeak,
        
        /// <summary>
        /// Issue related to database operations causing performance slowdowns.
        /// </summary>
        DatabaseBottleneck,
        
        /// <summary>
        /// Issue related to network communication delays.
        /// </summary>
        NetworkLatency,
        
        /// <summary>
        /// Issue related to multiple concurrent operations interfering with each other.
        /// </summary>
        ConcurrencyIssue
    }
}
