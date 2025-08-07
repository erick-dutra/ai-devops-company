using AIDevOpsCompany.Core.Models.DevelopmentTasks;

namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents an artifact generated during pipeline execution, including metadata and download information.
    /// </summary>
    public class ExecutionArtifact
    {
        /// <summary>
        /// Unique identifier for the artifact.
        /// </summary>
        public string ArtifactId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the execution that produced this artifact.
        /// </summary>
        public string ExecutionId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the artifact.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Type of the artifact.
        /// </summary>
        public ArtifactType Type { get; set; }
        /// <summary>
        /// URL to download the artifact.
        /// </summary>
        public string DownloadUrl { get; set; } = string.Empty;
        /// <summary>
        /// Size of the artifact in bytes.
        /// </summary>
        public long Size { get; set; }
        /// <summary>
        /// Hash of the artifact for integrity verification.
        /// </summary>
        public string Hash { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the artifact was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date and time when the artifact expires, if applicable.
        /// </summary>
        public DateTime? ExpiresAt { get; set; }
    }
}
