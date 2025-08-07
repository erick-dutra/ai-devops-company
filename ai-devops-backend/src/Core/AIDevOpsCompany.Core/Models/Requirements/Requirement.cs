namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Represents a requirement for a project.
    /// </summary>
    public class Requirement
    {
        /// <summary>
        /// Unique identifier for the requirement.
        /// </summary>
        public string RequirementId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the related project.
        /// </summary>
        public string ProjectId { get; set; } = string.Empty;
        /// <summary>
        /// Title of the requirement.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Description of the requirement.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of the requirement.
        /// </summary>
        public RequirementType Type { get; set; }
        /// <summary>
        /// Priority of the requirement.
        /// </summary>
        public RequirementPriority Priority { get; set; }
        /// <summary>
        /// Current status of the requirement.
        /// </summary>
        public RequirementStatus Status { get; set; } = RequirementStatus.Draft;
        /// <summary>
        /// Detailed technical specification for the requirement.
        /// </summary>
        public string DetailedSpecification { get; set; } = string.Empty;
        /// <summary>
        /// List of acceptance criteria for the requirement.
        /// </summary>
        public List<AcceptanceCriteria> AcceptanceCriteria { get; set; } = new();
        /// <summary>
        /// List of dependencies for this requirement.
        /// </summary>
        public List<string> Dependencies { get; set; } = new();
        /// <summary>
        /// List of clarification questions related to the requirement.
        /// </summary>
        public List<ClarificationQuestion> ClarificationQuestions { get; set; } = new();
        /// <summary>
        /// Source of the requirement.
        /// </summary>
        public RequirementSource Source { get; set; } = new();
        /// <summary>
        /// Change history for the requirement.
        /// </summary>
        public List<RequirementChange> ChangeHistory { get; set; } = new();
        /// <summary>
        /// Metrics related to the requirement.
        /// </summary>
        public RequirementMetrics Metrics { get; set; } = new();
        /// <summary>
        /// Agent who analyzed the requirement.
        /// </summary>
        public string AnalyzedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the requirement was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date and time when the requirement was last updated.
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// List of related requirements.
        /// </summary>
        public List<string> RelatedRequirements { get; set; } = new();
        /// <summary>
        /// Custom attributes for extensibility.
        /// </summary>
        public Dictionary<string, object> CustomAttributes { get; set; } = new();
    }
}
