namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the type of development artifact, such as source code, binary, documentation, or configuration.
    /// </summary>
    public enum ArtifactType
    {
        /// <summary>
        /// Source code artifact.
        /// </summary>
        SourceCode,
        /// <summary>
        /// Compiled binary artifact.
        /// </summary>
        CompiledBinary,
        /// <summary>
        /// Documentation artifact.
        /// </summary>
        Documentation,
        /// <summary>
        /// Test report artifact.
        /// </summary>
        TestReport,
        /// <summary>
        /// Configuration artifact.
        /// </summary>
        Configuration,
        /// <summary>
        /// Database artifact.
        /// </summary>
        Database,
        /// <summary>
        /// Image artifact.
        /// </summary>
        Image,
        /// <summary>
        /// Archive artifact (e.g., zip, tar).
        /// </summary>
        Archive,
    }
}
