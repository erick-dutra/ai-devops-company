namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents an action item related to an incident, such as a task or follow-up action.
    /// </summary>
    public class ActionItem
    {
        /// <summary>
        /// Gets or sets the unique identifier for the action item.
        /// </summary>
        public string ActionItemId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description of the action item.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the type of the action item.
        /// </summary>
        public ActionItemType Type { get; set; }
        /// <summary>
        /// Gets or sets the priority of the action item.
        /// </summary>
        public ActionItemPriority Priority { get; set; }
        /// <summary>
        /// Gets or sets the user or agent assigned to the action item.
        /// </summary>
        public string AssignedTo { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the due date for the action item.
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Gets or sets the status of the action item.
        /// </summary>
        public ActionItemStatus Status { get; set; } = ActionItemStatus.Open;
        /// <summary>
        /// Gets or sets the progress notes or status for the action item.
        /// </summary>
        public string Progress { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the completion date and time, if completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// Gets or sets any notes regarding the completion of the action item.
        /// </summary>
        public string CompletionNotes { get; set; } = string.Empty;
    }
}
