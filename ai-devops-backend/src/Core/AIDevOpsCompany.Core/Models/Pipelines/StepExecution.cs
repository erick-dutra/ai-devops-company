namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents the execution details of a pipeline step, including status, timing, and logs.
    /// </summary>
    public class StepExecution
    {
        /// <summary>
        /// Unique identifier for the step execution.
        /// </summary>
        public string StepExecutionId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the step being executed.
        /// </summary>
        public string StepId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the step being executed.
        /// </summary>
        public string StepName { get; set; } = string.Empty;
        /// <summary>
        /// Status of the step execution.
        /// </summary>
        public ExecutionStatus Status { get; set; } = ExecutionStatus.Pending;
        /// <summary>
        /// Date and time when the step execution started.
        /// </summary>
        public DateTime? StartedAt { get; set; }
        /// <summary>
        /// Date and time when the step execution completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// Duration of the step execution.
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Exit code returned by the step execution.
        /// </summary>
        public int ExitCode { get; set; }
        /// <summary>
        /// Standard output produced by the step.
        /// </summary>
        public string Output { get; set; } = string.Empty;
        /// <summary>
        /// Error output produced by the step.
        /// </summary>
        public string ErrorOutput { get; set; } = string.Empty;
        /// <summary>
        /// Logs generated during the step execution.
        /// </summary>
        public List<StepLog> Logs { get; set; } = new();
        /// <summary>
        /// Variables and metadata associated with the step execution.
        /// </summary>
        public Dictionary<string, object> Variables { get; set; } = new();
    }
}
