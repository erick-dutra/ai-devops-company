namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a software defect or bug tracked in the system.
    /// </summary>
    public class Bug
    {
        /// <summary>
        /// Unique identifier for the bug.
        /// </summary>
        public string BugId { get; set; } = string.Empty;
        
        /// <summary>
        /// Short title describing the bug.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        
        /// <summary>
        /// Detailed description of the bug.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        
        /// <summary>
        /// The severity level of the bug, indicating its impact.
        /// </summary>
        public BugSeverity Severity { get; set; }
        
        /// <summary>
        /// The priority level for fixing the bug.
        /// </summary>
        public BugPriority Priority { get; set; }
        
        /// <summary>
        /// Current status of the bug in its lifecycle.
        /// </summary>
        public BugStatus Status { get; set; } = BugStatus.Open;
        
        /// <summary>
        /// Category that classifies the type of bug.
        /// </summary>
        public BugCategory Category { get; set; }
        
        /// <summary>
        /// Instructions to reproduce the bug.
        /// </summary>
        public string StepsToReproduce { get; set; } = string.Empty;
        
        /// <summary>
        /// Description of the expected behavior when not encountering the bug.
        /// </summary>
        public string ExpectedBehavior { get; set; } = string.Empty;
        
        /// <summary>
        /// Description of the actual behavior observed when encountering the bug.
        /// </summary>
        public string ActualBehavior { get; set; } = string.Empty;
        
        /// <summary>
        /// Collection of attachments related to the bug, such as screenshots or logs.
        /// </summary>
        public List<BugAttachment> Attachments { get; set; } = new();
        
        /// <summary>
        /// Version of the software where the bug was discovered.
        /// </summary>
        public string FoundInVersion { get; set; } = string.Empty;
        
        /// <summary>
        /// Version of the software where the bug was fixed.
        /// </summary>
        public string FixedInVersion { get; set; } = string.Empty;
        
        /// <summary>
        /// Identifier of the agent assigned to fix the bug.
        /// </summary>
        public string AssignedToAgentId { get; set; } = string.Empty;
        
        /// <summary>
        /// Identifier of the agent who reported the bug.
        /// </summary>
        public string ReportedByAgentId { get; set; } = string.Empty;
        
        /// <summary>
        /// Date and time when the bug was reported.
        /// </summary>
        public DateTime ReportedAt { get; set; } = DateTime.UtcNow;
        
        /// <summary>
        /// Date and time when the bug was fixed, if applicable.
        /// </summary>
        public DateTime? FixedAt { get; set; }
        
        /// <summary>
        /// Collection of comments related to the bug.
        /// </summary>
        public List<BugComment> Comments { get; set; } = new();
        
        /// <summary>
        /// Dictionary of custom fields for storing additional bug information.
        /// </summary>
        public Dictionary<string, object> CustomFields { get; set; } = new();
    }
}
