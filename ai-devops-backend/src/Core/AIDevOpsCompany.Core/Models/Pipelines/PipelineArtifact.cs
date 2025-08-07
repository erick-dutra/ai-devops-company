using AIDevOpsCompany.Core.Models.DevelopmentTasks;

namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents an artifact produced by a pipeline, including metadata and content.
    /// </summary>
    public class PipelineArtifact
    {
        /// <summary>
        /// Gets or sets the unique identifier for the artifact.
        /// </summary>
        public string ArtifactId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the artifact.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the type of the artifact.
        /// </summary>
        public ArtifactType Type { get; set; }
        /// <summary>
        /// Gets or sets the file path of the artifact.
        /// </summary>
        public string Path { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the content of the artifact.
        /// </summary>
        public byte[] Content { get; set; } = Array.Empty<byte>();
        /// <summary>
        /// Gets or sets the size of the artifact in bytes.
        /// </summary>
        public long Size { get; set; }
        /// <summary>
        /// Gets or sets the hash of the artifact for integrity verification.
        /// </summary>
        public string Hash { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the metadata associated with the artifact.
        /// </summary>
        public ArtifactMetadata Metadata { get; set; } = new();
        /// <summary>
        /// Gets or sets the date and time when the artifact was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the name of the pipeline stage that created the artifact.
        /// </summary>
        public string CreatedByStage { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the pipeline job that created the artifact.
        /// </summary>
        public string CreatedByJob { get; set; } = string.Empty;
    }
}
