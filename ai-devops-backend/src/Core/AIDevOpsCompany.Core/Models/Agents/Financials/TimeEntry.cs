namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a time entry for work performed by an agent, including billing details.
    /// </summary>
    public class TimeEntry
    {
        /// <summary>
        /// Unique identifier for the time entry.
        /// </summary>
        public string TimeEntryId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the agent who performed the work.
        /// </summary>
        public string AgentId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the related task.
        /// </summary>
        public string TaskId { get; set; } = string.Empty;
        /// <summary>
        /// Description of the work performed.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Start time of the work.
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// End time of the work.
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// Duration of the work performed.
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Hourly rate applied to the work.
        /// </summary>
        public decimal HourlyRate { get; set; }
        /// <summary>
        /// Total amount billed for the time entry.
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Indicates if the time entry is billable.
        /// </summary>
        public bool Billable { get; set; }
        /// <summary>
        /// Status of the time entry.
        /// </summary>
        public TimeEntryStatus Status { get; set; } = TimeEntryStatus.Draft;
        /// <summary>
        /// Category of the work performed.
        /// </summary>
        public string Category { get; set; } = string.Empty;
        /// <summary>
        /// Additional notes for the time entry.
        /// </summary>
        public string Notes { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the entry was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Indicates if the entry was created automatically.
        /// </summary>
        public bool IsAutomated { get; set; }
    }
}
