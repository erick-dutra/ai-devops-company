namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Specifies the status of an execution within a pipeline (job, stage, or step).
    /// </summary>
    public enum ExecutionStatus
    {
        /// <summary>
        /// Execution is queued and waiting to be processed.
        /// </summary>
        Queued,
        /// <summary>
        /// Execution is pending and ready to start.
        /// </summary>
        Pending,
        /// <summary>
        /// Execution is currently running.
        /// </summary>
        Running,
        /// <summary>
        /// Execution completed successfully.
        /// </summary>
        Succeeded,
        /// <summary>
        /// Execution failed.
        /// </summary>
        Failed,
        /// <summary>
        /// Execution was cancelled.
        /// </summary>
        Cancelled,
        /// <summary>
        /// Execution was skipped.
        /// </summary>
        Skipped,
        /// <summary>
        /// Execution completed with partial success.
        /// </summary>
        PartiallySucceeded
    }
}
