using AIDevOpsCompany.Core.Models.Commons;
using AIDevOpsCompany.Core.Models.DevelopmentTasks;

namespace AIDevOpsCompany.Core.Models.Projects
{
    /// <summary>
    /// Represents a software project managed by the system.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        public string ProjectId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the project.
        /// </summary>
        public string ProjectName { get; set; } = string.Empty;
        /// <summary>
        /// Description of the project.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Name of the project manager.
        /// </summary>
        public string ProjectManager { get; set; } = string.Empty;
        /// <summary>
        /// Information about the client.
        /// </summary>
        public ClientInfo ClientInfo { get; set; } = new();
        /// <summary>
        /// Current status of the project.
        /// </summary>
        public ProjectStatus Status { get; set; } = ProjectStatus.Initiated;
        /// <summary>
        /// Start date of the project.
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// End date of the project.
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// List of project milestones.
        /// </summary>
        public List<Milestone> Milestones { get; set; } = new();
        /// <summary>
        /// List of agent IDs assigned to the project.
        /// </summary>
        public List<string> AssignedAgents { get; set; } = new();
        /// <summary>
        /// List of task IDs associated with the project.
        /// </summary>
        public List<string> Tasks { get; set; } = new();
        /// <summary>
        /// List of code versions for the project.
        /// </summary>
        public List<CodeVersion> CodeVersions { get; set; } = new();
        /// <summary>
        /// Project metrics.
        /// </summary>
        public ProjectMetrics Metrics { get; set; } = new();
        /// <summary>
        /// Date and time when the project was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date and time when the project was last updated.
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// User or agent who created the project.
        /// </summary>
        public string CreatedBy { get; set; } = string.Empty;
        /// <summary>
        /// User or agent who last updated the project.
        /// </summary>
        public string UpdatedBy { get; set; } = string.Empty;
        /// <summary>
        /// AI-generated analysis for the project.
        /// </summary>
        public string AIAnalysis { get; set; } = string.Empty;
        /// <summary>
        /// List of artifacts generated for the project.
        /// </summary>
        public List<GeneratedArtifact> GeneratedArtifacts { get; set; } = new();
        /// <summary>
        /// Indicates if the project has been processed by AI.
        /// </summary>
        public bool AIProcessed { get; set; }
    }
}
