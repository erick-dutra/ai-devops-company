namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the status of a code review.
    /// </summary>
    public enum CodeReviewStatus
    {
        /// <summary>
        /// The code review is pending and has not started.
        /// </summary>
        Pending,
        /// <summary>
        /// The code review is currently in progress.
        /// </summary>
        InProgress,
        /// <summary>
        /// The code review is completed.
        /// </summary>
        Completed,
        /// <summary>
        /// The code review is approved.
        /// </summary>
        Approved,
        /// <summary>
        /// The code review is rejected.
        /// </summary>
        Rejected
    }
}
