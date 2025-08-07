namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the different types of quality reports based on their focus area.
    /// </summary>
    public enum QualityReportType
    {
        /// <summary>
        /// Tests that verify the system functions correctly according to requirements.
        /// </summary>
        Functional,
        
        /// <summary>
        /// Tests that measure and analyze system performance metrics.
        /// </summary>
        Performance,
        
        /// <summary>
        /// Tests that identify and analyze security vulnerabilities.
        /// </summary>
        Security,
        
        /// <summary>
        /// Tests that verify compliance with accessibility standards.
        /// </summary>
        Accessibility,
        
        /// <summary>
        /// Tests that verify system compatibility across different platforms and environments.
        /// </summary>
        Compatibility,
        
        /// <summary>
        /// Tests that evaluate how user-friendly the system is.
        /// </summary>
        Usability,
        
        /// <summary>
        /// Tests that verify existing functionality still works after changes.
        /// </summary>
        Regression,
        
        /// <summary>
        /// Tests that verify correct interaction between integrated components.
        /// </summary>
        Integration
    }
}
