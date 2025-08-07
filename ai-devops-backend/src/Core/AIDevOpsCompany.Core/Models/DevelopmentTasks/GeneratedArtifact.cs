namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents an artifact generated during development, including metadata, content, and versioning information.
    /// </summary>
    public class GeneratedArtifact
    {
        /// <summary>
        /// The unique identifier for the artifact.
        /// </summary>
        public string ArtifactId { get; set; } = string.Empty;

        /// <summary>
        /// The name of the artifact.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The type of artifact.
        /// </summary>
        public ArtifactType Type { get; set; }

        /// <summary>
        /// The content of the artifact.
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// The hash of the artifact content.
        /// </summary>
        public string ContentHash { get; set; } = string.Empty;

        /// <summary>
        /// The size of the artifact in bytes.
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// The MIME type of the artifact.
        /// </summary>
        public string MimeType { get; set; } = string.Empty;

        /// <summary>
        /// Additional metadata for the artifact.
        /// </summary>
        public Dictionary<string, object> Metadata { get; set; } = new();

        /// <summary>
        /// The date and time when the artifact was created (UTC).
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The name or ID of the creator.
        /// </summary>
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// The ID of the agent that generated the artifact.
        /// </summary>
        public string GeneratedByAgentId { get; set; } = string.Empty;

        /// <summary>
        /// The version of the artifact.
        /// </summary>
        public string Version { get; set; } = string.Empty;
    }
}
