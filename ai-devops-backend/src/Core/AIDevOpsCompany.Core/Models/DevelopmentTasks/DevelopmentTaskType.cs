namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the type of development task.
    /// </summary>
    public enum DevelopmentTaskType
    {
        /// <summary>
        /// Task for implementing a new feature.
        /// </summary>
        NewFeature,
        /// <summary>
        /// Task for fixing a bug.
        /// </summary>
        BugFix,
        /// <summary>
        /// Task for enhancing existing functionality.
        /// </summary>
        Enhancement,
        /// <summary>
        /// Task for refactoring code.
        /// </summary>
        Refactoring,
        /// <summary>
        /// Task for writing or updating documentation.
        /// </summary>
        Documentation,
        /// <summary>
        /// Task for testing.
        /// </summary>
        Testing,
        /// <summary>
        /// Task for configuration work.
        /// </summary>
        Configuration,
        /// <summary>
        /// Task for database-related work.
        /// </summary>
        Database,
        /// <summary>
        /// Task for API-related work.
        /// </summary>
        API,
        /// <summary>
        /// Task for user interface work.
        /// </summary>
        UI
    }
}
