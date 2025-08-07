namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents an action taken to address a performance issue.
    /// </summary>
    public class PerformanceIssueAction
    {
        /// <summary>
        /// Unique identifier for the issue action.
        /// </summary>
        public string ActionId { get; set; } = string.Empty;
        /// <summary>
        /// Description of the action taken.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of the issue action.
        /// </summary>
        public PerformanceIssueActionType Type { get; set; }
        /// <summary>
        /// Status of the issue action.
        /// </summary>
        public PerformanceIssueActionStatus Status { get; set; } = PerformanceIssueActionStatus.Planned;
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
        /// <summary>
        /// Effectiveness score of the action.
        /// </summary>
        public double EffectivenessScore { get; set; }
    }
}
