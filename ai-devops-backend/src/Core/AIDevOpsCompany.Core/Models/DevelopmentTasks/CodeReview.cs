namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a code review, including reviewer, status, comments, decision, summary, and review timing.
    /// </summary>
    public class CodeReview
    {
        /// <summary>
        /// The unique identifier for the code review.
        /// </summary>
        public string ReviewId { get; set; } = string.Empty;

        /// <summary>
        /// The ID of the agent who performed the review.
        /// </summary>
        public string ReviewerAgentId { get; set; } = string.Empty;

        /// <summary>
        /// The status of the code review.
        /// </summary>
        public CodeReviewStatus Status { get; set; } = CodeReviewStatus.Pending;

        /// <summary>
        /// The list of comments made during the review.
        /// </summary>
        public List<ReviewComment> Comments { get; set; } = new();

        /// <summary>
        /// The final decision of the code review.
        /// </summary>
        public CodeReviewDecision Decision { get; set; }

        /// <summary>
        /// A summary of the code review.
        /// </summary>
        public string Summary { get; set; } = string.Empty;

        /// <summary>
        /// The date and time when the review was performed (UTC).
        /// </summary>
        public DateTime ReviewedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The duration of the code review.
        /// </summary>
        public TimeSpan ReviewDuration { get; set; }
    }
}
