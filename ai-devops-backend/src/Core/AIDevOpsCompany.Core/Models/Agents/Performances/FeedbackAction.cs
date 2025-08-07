namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents an action taken in response to feedback.
    /// </summary>
    public class FeedbackAction
    {
        /// <summary>
        /// Unique identifier for the feedback action.
        /// </summary>
        public string ActionId { get; set; } = string.Empty;
        /// <summary>
        /// Description of the action to be taken.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of feedback action (e.g., improvement, acknowledgment).
        /// </summary>
        public FeedbackActionType Type { get; set; }
        /// <summary>
        /// Status of the feedback action (e.g., planned, in progress, completed).
        /// </summary>
        public FeedbackActionStatus Status { get; set; } = FeedbackActionStatus.Planned;
        /// <summary>
        /// Date when the action is planned to be executed.
        /// </summary>
        public DateTime PlannedDate { get; set; }
        /// <summary>
        /// Date when the action was completed, if applicable.
        /// </summary>
        public DateTime? CompletedDate { get; set; }
        /// <summary>
        /// Result or outcome of the action.
        /// </summary>
        public string Result { get; set; } = string.Empty;
    }
}
