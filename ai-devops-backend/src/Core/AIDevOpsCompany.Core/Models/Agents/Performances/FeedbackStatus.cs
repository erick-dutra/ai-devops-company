namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the status of feedback provided.
    /// </summary>
    public enum FeedbackStatus
    {
        /// <summary>
        /// Feedback is new and has not been reviewed.
        /// </summary>
        New,
        /// <summary>
        /// Feedback has been reviewed.
        /// </summary>
        Reviewed,
        /// <summary>
        /// Feedback has been acknowledged by the recipient.
        /// </summary>
        Acknowledged,
        /// <summary>
        /// Action has been taken in response to the feedback.
        /// </summary>
        ActionTaken,
        /// <summary>
        /// Feedback is closed and no further action is required.
        /// </summary>
        Closed
    }
}
