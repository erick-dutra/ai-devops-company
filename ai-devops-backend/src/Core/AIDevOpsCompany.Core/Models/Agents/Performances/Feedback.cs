namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents feedback provided for an agent's performance or behavior.
    /// </summary>
    public class Feedback
    {
        /// <summary>
        /// Unique identifier for the feedback entry.
        /// </summary>
        public string FeedbackId { get; set; } = string.Empty;
        /// <summary>
        /// Type of feedback (e.g., positive, negative, neutral).
        /// </summary>
        public FeedbackType Type { get; set; }
        /// <summary>
        /// Source of the feedback (e.g., peer, manager, self).
        /// </summary>
        public FeedbackSource Source { get; set; }
        /// <summary>
        /// Identifier of the agent who provided the feedback.
        /// </summary>
        public string SourceAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Title or summary of the feedback.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Detailed content of the feedback.
        /// </summary>
        public string Content { get; set; } = string.Empty;
        /// <summary>
        /// Category of the feedback (e.g., communication, teamwork).
        /// </summary>
        public FeedbackCategory Category { get; set; }
        /// <summary>
        /// Numeric rating associated with the feedback.
        /// </summary>
        public double Rating { get; set; }
        /// <summary>
        /// Indicates whether the feedback was provided anonymously.
        /// </summary>
        public bool IsAnonymous { get; set; }
        /// <summary>
        /// Date and time when the feedback was provided.
        /// </summary>
        public DateTime ProvidedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Status of the feedback (e.g., new, addressed).
        /// </summary>
        public FeedbackStatus Status { get; set; } = FeedbackStatus.New;
        /// <summary>
        /// Response to the feedback, if any.
        /// </summary>
        public string Response { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the feedback was responded to, if applicable.
        /// </summary>
        public DateTime? RespondedAt { get; set; }
        /// <summary>
        /// List of actions taken in response to the feedback.
        /// </summary>
        public List<FeedbackAction> Actions { get; set; } = new();
    }
}
