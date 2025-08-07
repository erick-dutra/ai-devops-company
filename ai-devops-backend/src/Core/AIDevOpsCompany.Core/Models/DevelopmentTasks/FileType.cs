namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the type of file in a development project.
    /// </summary>
    public enum FileType
    {
        /// <summary>
        /// Source code file.
        /// </summary>
        Source,
        /// <summary>
        /// Test file.
        /// </summary>
        Test,
        /// <summary>
        /// Configuration file.
        /// </summary>
        Configuration,
        /// <summary>
        /// Documentation file.
        /// </summary>
        Documentation,
        /// <summary>
        /// Resource file (e.g., images, assets).
        /// </summary>
        Resource,
        /// <summary>
        /// Binary file.
        /// </summary>
        Binary
    }
}
