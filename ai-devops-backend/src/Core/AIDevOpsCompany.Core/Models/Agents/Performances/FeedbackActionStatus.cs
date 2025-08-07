namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the status of a feedback action.
    /// </summary>
    public enum FeedbackActionStatus
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
        Cancelled
    }
}
