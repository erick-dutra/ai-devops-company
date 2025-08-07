namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Represents a change made to a requirement, including type, values, and impact.
    /// </summary>
    public class RequirementChange
    {
        /// <summary>
        /// Gets or sets the unique identifier for the change.
        /// </summary>
        public string ChangeId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the type of change (e.g., Added, Modified, Removed).
        /// </summary>
        public string ChangeType { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the old value before the change.
        /// </summary>
        public string OldValue { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the new value after the change.
        /// </summary>
        public string NewValue { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the reason for the change.
        /// </summary>
        public string Reason { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the identifier of the agent who made the change.
        /// </summary>
        public string ChangedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the date and time when the change was made.
        /// </summary>
        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the impact of the change.
        /// </summary>
        public ChangeImpact Impact { get; set; } = new();
    }
}
