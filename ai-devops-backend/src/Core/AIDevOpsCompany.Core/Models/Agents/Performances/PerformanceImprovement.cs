namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents a performance improvement initiative for an agent.
    /// </summary>
    public class PerformanceImprovement
    {
        /// <summary>
        /// Unique identifier for the performance improvement.
        /// </summary>
        public string ImprovementId { get; set; } = string.Empty;
        /// <summary>
        /// Title of the performance improvement.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Description of the performance improvement.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of the improvement initiative.
        /// </summary>
        public ImprovementType Type { get; set; }
        /// <summary>
        /// Status of the improvement initiative.
        /// </summary>
        public ImprovementStatus Status { get; set; } = ImprovementStatus.Proposed;
        /// <summary>
        /// Expected impact of the improvement.
        /// </summary>
        public double ExpectedImpact { get; set; }
        /// <summary>
        /// Actual impact achieved by the improvement.
        /// </summary>
        public double ActualImpact { get; set; }
        /// <summary>
        /// Estimated effort required for the improvement.
        /// </summary>
        public TimeSpan EstimatedEffort { get; set; }
        /// <summary>
        /// Actual effort spent on the improvement.
        /// </summary>
        public TimeSpan ActualEffort { get; set; }
        /// <summary>
        /// Date and time when the improvement was proposed.
        /// </summary>
        public DateTime ProposedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date and time when the improvement was implemented, if applicable.
        /// </summary>
        public DateTime? ImplementedAt { get; set; }
        /// <summary>
        /// Date and time when the improvement was completed, if applicable.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// List of steps involved in the improvement.
        /// </summary>
        public List<ImprovementStep> Steps { get; set; } = new();
        /// <summary>
        /// Identifier of the agent who proposed the improvement.
        /// </summary>
        public string ProposedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the agent who implemented the improvement.
        /// </summary>
        public string ImplementedByAgentId { get; set; } = string.Empty;
    }
}
