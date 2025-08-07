namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the different types of test suites based on their scope and purpose.
    /// </summary>
    public enum TestSuiteType
    {
        /// <summary>
        /// Tests that verify individual components or functions in isolation.
        /// </summary>
        Unit,
        
        /// <summary>
        /// Tests that verify interactions between integrated components.
        /// </summary>
        Integration,
        
        /// <summary>
        /// Tests that verify complete user flows through the entire system.
        /// </summary>
        EndToEnd,
        
        /// <summary>
        /// Tests that measure system performance, speed, and resource usage.
        /// </summary>
        Performance,
        
        /// <summary>
        /// Tests that identify security vulnerabilities and verify security controls.
        /// </summary>
        Security,
        
        /// <summary>
        /// Tests that verify the system's compliance with accessibility standards.
        /// </summary>
        Accessibility,
        
        /// <summary>
        /// Tests that verify that recent changes don't break existing functionality.
        /// </summary>
        Regression
    }
}
