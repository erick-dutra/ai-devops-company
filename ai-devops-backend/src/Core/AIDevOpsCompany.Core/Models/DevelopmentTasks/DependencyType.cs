namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the type of software dependency.
    /// </summary>
    public enum DependencyType
    {
        /// <summary>
        /// Dependency required at runtime.
        /// </summary>
        Runtime,
        /// <summary>
        /// Dependency required for development.
        /// </summary>
        Development,
        /// <summary>
        /// Dependency required for testing.
        /// </summary>
        Test,
        /// <summary>
        /// Dependency required for build process.
        /// </summary>
        Build,
        /// <summary>
        /// Optional dependency.
        /// </summary>
        Optional
    }
}
