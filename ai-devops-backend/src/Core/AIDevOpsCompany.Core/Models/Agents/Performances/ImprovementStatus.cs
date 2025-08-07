namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the status of an improvement initiative or step.
    /// </summary>
    public enum ImprovementStatus
    {
        /// <summary>
        /// The improvement is proposed and awaiting approval.
        /// </summary>
        Proposed,
        /// <summary>
        /// The improvement has been approved.
        /// </summary>
        Approved,
        /// <summary>
        /// The improvement is currently in progress.
        /// </summary>
        InProgress,
        /// <summary>
        /// The improvement has been completed.
        /// </summary>
        Completed,
        /// <summary>
        /// The improvement has been cancelled.
        /// </summary>
        Cancelled,
        /// <summary>
        /// The improvement is on hold.
        /// </summary>
        OnHold
    }
}
