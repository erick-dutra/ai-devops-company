namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents an attachment associated with an invoice.
    /// </summary>
    public class InvoiceAttachment
    {
        /// <summary>
        /// Gets or sets the unique identifier for the attachment.
        /// </summary>
        public string AttachmentId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the file name of the attachment.
        /// </summary>
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the content type (MIME type) of the attachment.
        /// </summary>
        public string ContentType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the binary content of the attachment.
        /// </summary>
        public byte[] Content { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// Gets or sets the size of the attachment in bytes.
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// Gets or sets the description of the attachment.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the creation date of the attachment.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
