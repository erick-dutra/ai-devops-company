namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents the results of security tests conducted on a software system.
    /// </summary>
    public class SecurityTestResults
    {
        /// <summary>
        /// Unique identifier for the security test.
        /// </summary>
        public string TestId { get; set; } = string.Empty;
        
        /// <summary>
        /// Collection of security vulnerabilities identified during testing.
        /// </summary>
        public List<SecurityVulnerability> Vulnerabilities { get; set; } = new();
        
        /// <summary>
        /// Collection of individual security test cases executed.
        /// </summary>
        public List<SecurityTestCase> TestCases { get; set; } = new();
        
        /// <summary>
        /// Aggregated security metrics from the tests.
        /// </summary>
        public SecurityMetrics Metrics { get; set; } = new();
        
        /// <summary>
        /// Date and time when the security tests were executed.
        /// </summary>
        public DateTime ExecutedAt { get; set; } = DateTime.UtcNow;
    }
}
