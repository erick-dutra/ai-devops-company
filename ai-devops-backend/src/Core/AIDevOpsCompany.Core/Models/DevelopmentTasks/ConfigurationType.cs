namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the type of configuration file.
    /// </summary>
    public enum ConfigurationType
    {
        /// <summary>
        /// Application configuration.
        /// </summary>
        Application,
        /// <summary>
        /// Database configuration.
        /// </summary>
        Database,
        /// <summary>
        /// Environment configuration.
        /// </summary>
        Environment,
        /// <summary>
        /// Deployment configuration.
        /// </summary>
        Deployment,
        /// <summary>
        /// Security configuration.
        /// </summary>
        Security,
        /// <summary>
        /// Logging configuration.
        /// </summary>
        Logging,
        /// <summary>
        /// Monitoring configuration.
        /// </summary>
        Monitoring
    }
}
