namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents metadata information for a pipeline artifact, such as version, tags, author, license, and additional properties.
    /// </summary>
    public class ArtifactMetadata
    {
        /// <summary>
        /// Version of the artifact.
        /// </summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>
        /// Description of the artifact.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// List of tags associated with the artifact.
        /// </summary>
        public List<string> Tags { get; set; } = new();
        /// <summary>
        /// Additional properties or metadata for the artifact.
        /// </summary>
        public Dictionary<string, object> Properties { get; set; } = new();
        /// <summary>
        /// License information for the artifact.
        /// </summary>
        public string License { get; set; } = string.Empty;
        /// <summary>
        /// Author of the artifact.
        /// </summary>
        public string Author { get; set; } = string.Empty;
    }
}
