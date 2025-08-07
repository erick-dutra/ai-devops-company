namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Defines the possible events that can occur during pipeline execution.
    /// </summary>
    public enum PipelineEvent
    {
        /// <summary>
        /// The pipeline execution has started.
        /// </summary>
        Started,
        /// <summary>
        /// The pipeline execution has completed successfully.
        /// </summary>
        Completed,
        /// <summary>
        /// The pipeline execution has failed.
        /// </summary>
        Failed,
        /// <summary>
        /// The pipeline execution was cancelled.
        /// </summary>
        Cancelled,
        /// <summary>
        /// A stage within the pipeline has started.
        /// </summary>
        StageStarted,
        /// <summary>
        /// A stage within the pipeline has completed.
        /// </summary>
        StageCompleted,
        /// <summary>
        /// A stage within the pipeline has failed.
        /// </summary>
        StageFailed,
        /// <summary>
        /// The pipeline requires approval to proceed.
        /// </summary>
        ApprovalRequired,
        /// <summary>
        /// The required approval has been completed.
        /// </summary>
        ApprovalCompleted
    }
}
