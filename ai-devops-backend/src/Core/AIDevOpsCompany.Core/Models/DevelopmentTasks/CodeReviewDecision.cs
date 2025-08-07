namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the possible decisions for a code review.
    /// </summary>
    public enum CodeReviewDecision
    {
        /// <summary>
        /// The code is approved.
        /// </summary>
        Approve,
        /// <summary>
        /// Changes are requested before approval.
        /// </summary>
        RequestChanges,
        /// <summary>
        /// General comments are provided without approval or rejection.
        /// </summary>
        Comment,
        /// <summary>
        /// The code is rejected.
        /// </summary>
        Reject
    }
}
