namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Represents a clarification question related to a requirement.
    /// </summary>
    public class ClarificationQuestion
    {
        /// <summary>
        /// Gets or sets the unique identifier for the question.
        /// </summary>
        public string QuestionId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        public string Question { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the context for the question.
        /// </summary>
        public string Context { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the priority of the question.
        /// </summary>
        public QuestionPriority Priority { get; set; }
        /// <summary>
        /// Gets or sets the status of the question.
        /// </summary>
        public QuestionStatus Status { get; set; } = QuestionStatus.Open;
        /// <summary>
        /// Gets or sets the answer to the question.
        /// </summary>
        public string Answer { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the date and time when the question was asked.
        /// </summary>
        public DateTime AskedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the date and time when the question was answered, if answered.
        /// </summary>
        public DateTime? AnsweredAt { get; set; }
        /// <summary>
        /// Gets or sets the identifier of the agent who asked the question.
        /// </summary>
        public string AskedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the identifier of the person who answered the question.
        /// </summary>
        public string AnsweredBy { get; set; } = string.Empty;
    }
}
