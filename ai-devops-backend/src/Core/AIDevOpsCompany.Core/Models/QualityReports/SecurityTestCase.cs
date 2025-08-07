using AIDevOpsCompany.Core.Models.Projects;

namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents an individual security test executed as part of security testing.
    /// </summary>
    public class SecurityTestCase
    {
        /// <summary>
        /// Unique identifier for the security test case.
        /// </summary>
        public string TestCaseId { get; set; } = string.Empty;
        
        /// <summary>
        /// Name or title of the security test case.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// Type of security test performed.
        /// </summary>
        public SecurityTestType Type { get; set; }
        
        /// <summary>
        /// Result of executing the test case.
        /// </summary>
        public TestResult Result { get; set; }
        
        /// <summary>
        /// Detailed information about the test execution and findings.
        /// </summary>
        public string Details { get; set; } = string.Empty;
        
        /// <summary>
        /// Date and time when the security test case was executed.
        /// </summary>
        public DateTime ExecutedAt { get; set; } = DateTime.UtcNow;
    }
}
