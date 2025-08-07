namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents a post-incident review session for analyzing and learning from an incident.
    /// </summary>
    public class PostIncidentReview
    {
        /// <summary>
        /// Gets or sets the unique identifier for the review.
        /// </summary>
        public string ReviewId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the status of the post-incident review.
        /// </summary>
        public PostIncidentReviewStatus Status { get; set; } = PostIncidentReviewStatus.Pending;
        /// <summary>
        /// Gets or sets the scheduled date and time for the review.
        /// </summary>
        public DateTime ScheduledAt { get; set; }
        /// <summary>
        /// Gets or sets the actual date and time when the review was conducted.
        /// </summary>
        public DateTime? ConductedAt { get; set; }
        /// <summary>
        /// Gets or sets the list of participants in the review.
        /// </summary>
        public List<string> Participants { get; set; } = new();
        /// <summary>
        /// Gets or sets the name or ID of the review facilitator.
        /// </summary>
        public string Facilitator { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the findings from the review.
        /// </summary>
        public ReviewFindings Findings { get; set; } = new();
        /// <summary>
        /// Gets or sets the list of action items from the review.
        /// </summary>
        public List<ActionItem> ActionItems { get; set; } = new();
        /// <summary>
        /// Gets or sets the list of lessons learned from the incident.
        /// </summary>
        public List<LessonsLearned> LessonsLearned { get; set; } = new();
        /// <summary>
        /// Gets or sets the summary of the post-incident review.
        /// </summary>
        public string Summary { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the list of attachments related to the review.
        /// </summary>
        public List<string> Attachments { get; set; } = new();
        /// <summary>
        /// Gets or sets the date and time when the review was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
    }
}
