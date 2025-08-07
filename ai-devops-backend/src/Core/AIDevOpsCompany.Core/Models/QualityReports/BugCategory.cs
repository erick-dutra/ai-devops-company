namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the categories for classifying bugs based on their nature.
    /// </summary>
    public enum BugCategory
    {
        /// <summary>
        /// Issues related to the core functionality of the system.
        /// </summary>
        Functional,
        
        /// <summary>
        /// Issues related to system speed, responsiveness, or resource usage.
        /// </summary>
        Performance,
        
        /// <summary>
        /// Issues related to system security vulnerabilities or exposures.
        /// </summary>
        Security,
        
        /// <summary>
        /// Issues related to the user interface appearance or behavior.
        /// </summary>
        UI,
        
        /// <summary>
        /// Issues related to data storage, retrieval, or manipulation.
        /// </summary>
        Data,
        
        /// <summary>
        /// Issues related to interactions between system components or external systems.
        /// </summary>
        Integration,
        
        /// <summary>
        /// Issues related to system configuration or environment settings.
        /// </summary>
        Configuration
    }
}
