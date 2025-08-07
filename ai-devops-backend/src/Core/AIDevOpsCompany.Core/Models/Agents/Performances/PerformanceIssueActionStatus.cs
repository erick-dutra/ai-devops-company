namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the status of an action taken to address a performance issue.
    /// </summary>
    public enum PerformanceIssueActionStatus
    {
        /// <summary>
        /// The action is planned but not yet started.
        /// </summary>
        Planned,
        /// <summary>
        /// The action is currently in progress.
        /// </summary>
        InProgress,
        /// <summary>
        /// The action has been completed.
        /// </summary>
        Completed,
        /// <summary>
        /// The action was cancelled and will not be completed.
        /// </summary>
        Cancelled,
        /// <summary>
        /// The action failed to achieve its intended result.
        /// </summary>
        Failed
    }
}
