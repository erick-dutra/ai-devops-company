namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents an action taken as part of an incident resolution.
    /// </summary>
    public class ResolutionAction
    {
        /// <summary>
        /// Unique identifier for the resolution action.
        /// </summary>
        public string ActionId { get; set; } = string.Empty;
        /// <summary>
        /// Description of the resolution action.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of the resolution action.
        /// </summary>
        public ResolutionActionType Type { get; set; }
        /// <summary>
        /// Indicates whether the action has been completed.
        /// </summary>
        public bool Completed { get; set; }
        /// <summary>
        /// Date and time when the action was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// Identifier of the agent who completed the action.
        /// </summary>
        public string CompletedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Result or outcome of the action.
        /// </summary>
        public string Result { get; set; } = string.Empty;
    }
}
