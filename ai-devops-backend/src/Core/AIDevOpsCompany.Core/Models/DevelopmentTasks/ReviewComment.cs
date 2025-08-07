namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a comment made during a code review, including file, line, type, severity, and suggestion.
    /// </summary>
    public class ReviewComment
    {
        /// <summary>
        /// The unique identifier for the comment.
        /// </summary>
        public string CommentId { get; set; } = string.Empty;

        /// <summary>
        /// The name of the file where the comment was made.
        /// </summary>
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// The line number in the file where the comment was made.
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// The type of the review comment.
        /// </summary>
        public ReviewCommentType Type { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// A suggestion for improvement, if any.
        /// </summary>
        public string Suggestion { get; set; } = string.Empty;

        /// <summary>
        /// The severity of the review comment.
        /// </summary>
        public ReviewCommentSeverity Severity { get; set; }

        /// <summary>
        /// The date and time when the comment was created (UTC).
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The name or ID of the person who created the comment.
        /// </summary>
        public string CreatedBy { get; set; } = string.Empty;
    }
}
