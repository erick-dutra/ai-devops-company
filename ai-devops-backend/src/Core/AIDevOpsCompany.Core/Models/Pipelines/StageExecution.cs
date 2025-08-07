namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents the execution details of a pipeline stage.
    /// </summary>
    public class StageExecution
    {
        /// <summary>
        /// Unique identifier for the stage execution.
        /// </summary>
        public string StageExecutionId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the stage.
        /// </summary>
        public string StageId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the stage.
        /// </summary>
        public string StageName { get; set; } = string.Empty;
        /// <summary>
        /// Status of the stage execution.
        /// </summary>
        public ExecutionStatus Status { get; set; } = ExecutionStatus.Pending;
        /// <summary>
        /// List of job executions in the stage.
        /// </summary>
        public List<JobExecution> JobExecutions { get; set; } = new();
        /// <summary>
        /// Start time of the stage execution.
        /// </summary>
        public DateTime? StartedAt { get; set; }
        /// <summary>
        /// Completion time of the stage execution.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// Duration of the stage execution.
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Agent assigned to the stage.
        /// </summary>
        public string Agent { get; set; } = string.Empty;
        /// <summary>
        /// Variables and metadata for the stage.
        /// </summary>
        public Dictionary<string, object> Variables { get; set; } = new();
    }
}
