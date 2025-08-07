namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents the execution details of a pipeline run, including status, timing, artifacts, and logs.
    /// </summary>
    public class PipelineExecution
    {
        /// <summary>
        /// Unique identifier for the pipeline execution.
        /// </summary>
        public string ExecutionId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the pipeline being executed.
        /// </summary>
        public string PipelineId { get; set; } = string.Empty;
        /// <summary>
        /// Build number for this execution.
        /// </summary>
        public int BuildNumber { get; set; }
        /// <summary>
        /// Status of the pipeline execution.
        /// </summary>
        public ExecutionStatus Status { get; set; } = ExecutionStatus.Queued;
        /// <summary>
        /// Trigger information for this execution.
        /// </summary>
        public ExecutionTrigger Trigger { get; set; } = new();
        /// <summary>
        /// List of stage executions in this pipeline run.
        /// </summary>
        public List<StageExecution> StageExecutions { get; set; } = new();
        /// <summary>
        /// List of artifacts produced during execution.
        /// </summary>
        public List<ExecutionArtifact> Artifacts { get; set; } = new();
        /// <summary>
        /// Metrics collected during execution.
        /// </summary>
        public ExecutionMetrics Metrics { get; set; } = new();
        /// <summary>
        /// Identifier of the agent that triggered the execution.
        /// </summary>
        public string TriggeredByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the execution was queued.
        /// </summary>
        public DateTime QueuedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date and time when the execution started.
        /// </summary>
        public DateTime? StartedAt { get; set; }
        /// <summary>
        /// Date and time when the execution completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// Total duration of the execution.
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Source version (commit, tag, etc.) used for this execution.
        /// </summary>
        public string SourceVersion { get; set; } = string.Empty;
        /// <summary>
        /// Source branch used for this execution.
        /// </summary>
        public string SourceBranch { get; set; } = string.Empty;
        /// <summary>
        /// Variables and metadata associated with the execution.
        /// </summary>
        public Dictionary<string, object> Variables { get; set; } = new();
        /// <summary>
        /// Logs generated during the execution.
        /// </summary>
        public List<ExecutionLog> Logs { get; set; } = new();
    }
}
