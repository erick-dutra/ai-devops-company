namespace AIDevOpsCompany.Core.Models.Projects
{
    /// <summary>
    /// Specifies the type of test that was executed.
    /// </summary>
    public enum TestType
    {
        /// <summary>
        /// Unit tests that verify individual components in isolation.
        /// </summary>
        Unit,
        
        /// <summary>
        /// Integration tests that verify interactions between components.
        /// </summary>
        Integration,
        
        /// <summary>
        /// End-to-end tests that verify the complete application flow.
        /// </summary>
        EndToEnd,
        
        /// <summary>
        /// Tests that verify system performance under load.
        /// </summary>
        Performance,
        
        /// <summary>
        /// Tests that verify system security against vulnerabilities.
        /// </summary>
        Security,
        
        /// <summary>
        /// Tests that verify system accessibility for users with disabilities.
        /// </summary>
        Accessibility,
        
        /// <summary>
        /// Tests conducted manually by testers.
        /// </summary>
        Manual
    }
}
