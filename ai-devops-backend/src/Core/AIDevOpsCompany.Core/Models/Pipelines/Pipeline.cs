namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a CI/CD pipeline for a project.
    /// </summary>
    public class Pipeline
    {
        /// <summary>
        /// Unique identifier for the pipeline.
        /// </summary>
        public string PipelineId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the related project.
        /// </summary>
        public string ProjectId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the pipeline.
        /// </summary>
        public string PipelineName { get; set; } = string.Empty;
        /// <summary>
        /// Description of the pipeline.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of the pipeline.
        /// </summary>
        public PipelineType Type { get; set; }
        /// <summary>
        /// Current status of the pipeline.
        /// </summary>
        public PipelineStatus Status { get; set; } = PipelineStatus.Draft;
        /// <summary>
        /// List of stages in the pipeline.
        /// </summary>
        public List<PipelineStage> Stages { get; set; } = new();
        /// <summary>
        /// Configuration details for the pipeline.
        /// </summary>
        public PipelineConfiguration Configuration { get; set; } = new();
        /// <summary>
        /// List of pipeline executions.
        /// </summary>
        public List<PipelineExecution> Executions { get; set; } = new();
        /// <summary>
        /// Trigger configuration for the pipeline.
        /// </summary>
        public PipelineTrigger Trigger { get; set; } = new();
        /// <summary>
        /// List of artifacts produced by the pipeline.
        /// </summary>
        public List<PipelineArtifact> Artifacts { get; set; } = new();
        /// <summary>
        /// Metrics related to the pipeline.
        /// </summary>
        public PipelineMetrics Metrics { get; set; } = new();
        /// <summary>
        /// Identifier of the agent who created the pipeline.
        /// </summary>
        public string CreatedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the pipeline was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date and time when the pipeline was last updated.
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Variables used in the pipeline.
        /// </summary>
        public Dictionary<string, object> Variables { get; set; } = new();
    }
}
