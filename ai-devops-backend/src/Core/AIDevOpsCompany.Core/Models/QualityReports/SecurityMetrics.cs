namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents statistical metrics related to security testing and vulnerabilities.
    /// </summary>
    public class SecurityMetrics
    {
        /// <summary>
        /// Total number of security vulnerabilities found across all severity levels.
        /// </summary>
        public int TotalVulnerabilities { get; set; }
        
        /// <summary>
        /// Number of critical severity vulnerabilities found.
        /// </summary>
        public int CriticalVulnerabilities { get; set; }
        
        /// <summary>
        /// Number of high severity vulnerabilities found.
        /// </summary>
        public int HighVulnerabilities { get; set; }
        
        /// <summary>
        /// Number of medium severity vulnerabilities found.
        /// </summary>
        public int MediumVulnerabilities { get; set; }
        
        /// <summary>
        /// Number of low severity vulnerabilities found.
        /// </summary>
        public int LowVulnerabilities { get; set; }
        
        /// <summary>
        /// Overall security score as a percentage (higher is better).
        /// </summary>
        public double SecurityScore { get; set; }
        
        /// <summary>
        /// Collection of additional custom security metrics.
        /// </summary>
        public Dictionary<string, object> CustomMetrics { get; set; } = new();
    }
}
