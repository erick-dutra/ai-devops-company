namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the different types of security tests used to evaluate system security.
    /// </summary>
    public enum SecurityTestType
    {
        /// <summary>
        /// Analysis of source code without executing it to find security vulnerabilities.
        /// </summary>
        StaticAnalysis,
        
        /// <summary>
        /// Analysis of running applications to find security vulnerabilities during execution.
        /// </summary>
        DynamicAnalysis,
        
        /// <summary>
        /// Simulated attacks on a system to identify security weaknesses.
        /// </summary>
        PenetrationTest,
        
        /// <summary>
        /// Systematic review of security vulnerabilities in a system.
        /// </summary>
        VulnerabilityAssessment,
        
        /// <summary>
        /// Manual or automated review of source code for security issues.
        /// </summary>
        CodeReview,
        
        /// <summary>
        /// Analysis of third-party dependencies for known security vulnerabilities.
        /// </summary>
        DependencyCheck
    }
}
