namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a file or document attached to a bug report, such as a screenshot, log, or other supporting evidence.
    /// </summary>
    public class BugAttachment
    {
        /// <summary>
        /// Unique identifier for the attachment.
        /// </summary>
        public string AttachmentId { get; set; } = string.Empty;
        
        /// <summary>
        /// Name of the attachment file.
        /// </summary>
        public string FileName { get; set; } = string.Empty;
        
        /// <summary>
        /// Type of the attachment (e.g., Screenshot, Log, etc.).
        /// </summary>
        public AttachmentType Type { get; set; }
        
        /// <summary>
        /// Binary content of the attachment file.
        /// </summary>
        public byte[] Content { get; set; } = Array.Empty<byte>();
        
        /// <summary>
        /// Description providing context for the attachment.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        
        /// <summary>
        /// Date and time when the attachment was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
