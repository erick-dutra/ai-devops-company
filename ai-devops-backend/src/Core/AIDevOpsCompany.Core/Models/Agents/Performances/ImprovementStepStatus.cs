namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the status of a step within an improvement plan.
    /// </summary>
    public enum ImprovementStepStatus
    {
        /// <summary>
        /// The step is pending and has not started.
        /// </summary>
        Pending,
        /// <summary>
        /// The step is currently in progress.
        /// </summary>
        InProgress,
        /// <summary>
        /// The step has been completed.
        /// </summary>
        Completed,
        /// <summary>
        /// The step is blocked and cannot proceed.
        /// </summary>
        Blocked,
        /// <summary>
        /// The step has been cancelled.
        /// </summary>
        Cancelled
    }
}
