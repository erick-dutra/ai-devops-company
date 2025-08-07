namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a percentile measurement of response time used for statistical analysis of performance.
    /// </summary>
    public class ResponseTimePercentile
    {
        /// <summary>
        /// The percentile value (e.g., 50 for 50th percentile, 90 for 90th percentile).
        /// </summary>
        public double Percentile { get; set; }
        
        /// <summary>
        /// The response time at this percentile, measured in milliseconds.
        /// </summary>
        public double ResponseTime { get; set; }
    }
}
