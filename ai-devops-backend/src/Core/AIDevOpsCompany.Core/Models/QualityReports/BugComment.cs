namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a comment or note added to a bug report to provide additional information or updates.
    /// </summary>
    public class BugComment
    {
        /// <summary>
        /// Unique identifier for the comment.
        /// </summary>
        public string CommentId { get; set; } = string.Empty;
        
        /// <summary>
        /// The actual content of the comment.
        /// </summary>
        public string Comment { get; set; } = string.Empty;
        
        /// <summary>
        /// Identifier of the agent who authored the comment.
        /// </summary>
        public string AuthorAgentId { get; set; } = string.Empty;
        
        /// <summary>
        /// Date and time when the comment was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        /// <summary>
        /// Indicates if the comment is for internal team use only and not visible to clients.
        /// </summary>
        public bool IsInternal { get; set; }
    }
}
