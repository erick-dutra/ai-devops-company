namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents the execution details of a pipeline job.
    /// </summary>
    public class JobExecution
    {
        /// <summary>
        /// Unique identifier for the job execution.
        /// </summary>
        public string JobExecutionId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the job.
        /// </summary>
        public string JobId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the job.
        /// </summary>
        public string JobName { get; set; } = string.Empty;
        /// <summary>
        /// Status of the job execution.
        /// </summary>
        public ExecutionStatus Status { get; set; } = ExecutionStatus.Pending;
        /// <summary>
        /// List of step executions in the job.
        /// </summary>
        public List<StepExecution> StepExecutions { get; set; } = new();
        /// <summary>
        /// Start time of the job execution.
        /// </summary>
        public DateTime? StartedAt { get; set; }
        /// <summary>
        /// Completion time of the job execution.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// Duration of the job execution.
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Agent assigned to the job.
        /// </summary>
        public string Agent { get; set; } = string.Empty;
        /// <summary>
        /// Exit code of the job execution.
        /// </summary>
        public int ExitCode { get; set; }
        /// <summary>
        /// Variables and metadata for the job.
        /// </summary>
        public Dictionary<string, object> Variables { get; set; } = new();
    }
}
