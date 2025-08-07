namespace AIDevOpsCompany.Core.Models.Projects
{
    /// <summary>
    /// Represents a version of code for a project.
    /// </summary>
    public class CodeVersion
    {
        /// <summary>
        /// Unique identifier for the code version.
        /// </summary>
        public string VersionId { get; set; } = string.Empty;
        
        /// <summary>
        /// Version number or name.
        /// </summary>
        public string Version { get; set; } = string.Empty;
        
        /// <summary>
        /// Description of the code version.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        
        /// <summary>
        /// Compressed data of the code version.
        /// </summary>
        public byte[] ZipData { get; set; } = Array.Empty<byte>();
        
        /// <summary>
        /// Hash of the code for integrity verification.
        /// </summary>
        public string CodeHash { get; set; } = string.Empty;
        
        /// <summary>
        /// Test evidences for this code version.
        /// </summary>
        public List<TestEvidence> TestEvidences { get; set; } = new();
        
        /// <summary>
        /// Metrics for this code version.
        /// </summary>
        public CodeMetrics Metrics { get; set; } = new();
        
        /// <summary>
        /// Identifier of the agent that generated this version.
        /// </summary>
        public string GeneratedByAgentId { get; set; } = string.Empty;
        
        /// <summary>
        /// Date and time when this version was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        /// <summary>
        /// User or agent who created this version.
        /// </summary>
        public string CreatedBy { get; set; } = string.Empty;
        
        /// <summary>
        /// List of files that were changed in this version.
        /// </summary>
        public List<string> ChangedFiles { get; set; } = new();
        
        /// <summary>
        /// Message describing the changes in this version.
        /// </summary>
        public string CommitMessage { get; set; } = string.Empty;
    }
}
