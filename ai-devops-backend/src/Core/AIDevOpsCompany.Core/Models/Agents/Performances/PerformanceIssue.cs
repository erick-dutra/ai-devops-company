namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents a performance issue identified for an agent.
    /// </summary>
    public class PerformanceIssue
    {
        /// <summary>
        /// Unique identifier for the performance issue.
        /// </summary>
        public string IssueId { get; set; } = string.Empty;
        /// <summary>
        /// Title of the performance issue.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Description of the performance issue.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of the performance issue.
        /// </summary>
        public PerformanceIssueType Type { get; set; }
        /// <summary>
        /// Severity of the performance issue.
        /// </summary>
        public PerformanceIssueSeverity Severity { get; set; }
        /// <summary>
        /// Status of the performance issue.
        /// </summary>
        public PerformanceIssueStatus Status { get; set; } = PerformanceIssueStatus.Open;
        /// <summary>
        /// Date and time when the issue was identified.
        /// </summary>
        public DateTime IdentifiedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date and time when the issue was resolved, if applicable.
        /// </summary>
        public DateTime? ResolvedAt { get; set; }
        /// <summary>
        /// Root cause of the performance issue.
        /// </summary>
        public string RootCause { get; set; } = string.Empty;
        /// <summary>
        /// List of areas impacted by the issue.
        /// </summary>
        public List<string> ImpactAreas { get; set; } = new();
        /// <summary>
        /// List of actions taken to address the issue.
        /// </summary>
        public List<PerformanceIssueAction> Actions { get; set; } = new();
        /// <summary>
        /// Identifier of the agent who identified the issue.
        /// </summary>
        public string IdentifiedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the agent assigned to resolve the issue.
        /// </summary>
        public string AssignedToAgentId { get; set; } = string.Empty;
    }
}
