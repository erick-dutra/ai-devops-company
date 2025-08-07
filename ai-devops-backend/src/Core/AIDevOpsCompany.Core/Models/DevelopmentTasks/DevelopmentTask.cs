namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a software development task within a project.
    /// </summary>
    public class DevelopmentTask
    {
        /// <summary>
        /// Unique identifier for the development task.
        /// </summary>
        public string TaskId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the related project.
        /// </summary>
        public string ProjectId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the related requirement.
        /// </summary>
        public string RequirementId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the development task.
        /// </summary>
        public string TaskName { get; set; } = string.Empty;
        /// <summary>
        /// Description of the development task.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of the development task.
        /// </summary>
        public DevelopmentTaskType TaskType { get; set; }
        /// <summary>
        /// Priority of the development task.
        /// </summary>
        public DevelopmentTaskPriority Priority { get; set; }
        /// <summary>
        /// Current status of the task.
        /// </summary>
        public Commons.TaskStatus Status { get; set; } = Commons.TaskStatus.Pending;
        /// <summary>
        /// Identifier of the agent assigned to the task.
        /// </summary>
        public string AssignedToAgentId { get; set; } = string.Empty;
        /// <summary>
        /// List of dependencies for this task.
        /// </summary>
        public List<string> Dependencies { get; set; } = new();
        /// <summary>
        /// Code details related to the task.
        /// </summary>
        public CodeDetails CodeDetails { get; set; } = new();
        /// <summary>
        /// List of generated artifacts by this task.
        /// </summary>
        public List<GeneratedArtifact> GeneratedArtifacts { get; set; } = new();
        /// <summary>
        /// Development metrics for this task.
        /// </summary>
        public DevelopmentMetrics Metrics { get; set; } = new();
        /// <summary>
        /// Quality assessment for this task.
        /// </summary>
        public DevQualityAssessment QualityAssessment { get; set; } = new();
        /// <summary>
        /// List of code reviews for this task.
        /// </summary>
        public List<CodeReview> CodeReviews { get; set; } = new();
        /// <summary>
        /// Repository information for this task.
        /// </summary>
        public RepositoryInfo RepositoryInfo { get; set; } = new();
        /// <summary>
        /// Date and time when the task was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date and time when the task was started.
        /// </summary>
        public DateTime? StartedAt { get; set; }
        /// <summary>
        /// Date and time when the task was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// Date and time when the task was last updated.
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Additional parameters for the task.
        /// </summary>
        public Dictionary<string, object> Parameters { get; set; } = new();
        /// <summary>
        /// Programming language used in the task.
        /// </summary>
        public string Language { get; set; }= string.Empty;
        /// <summary>
        /// Generated code for the task.
        /// </summary>
        public string GeneratedCode { get; set; } = string.Empty;
    }
}
