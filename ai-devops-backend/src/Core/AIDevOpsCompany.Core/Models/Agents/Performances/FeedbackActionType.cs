namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the type of action taken in response to feedback.
    /// </summary>
    public enum FeedbackActionType
    {
        /// <summary>
        /// Action involves training activities.
        /// </summary>
        Training,
        /// <summary>
        /// Action involves coaching or mentoring.
        /// </summary>
        Coaching,
        /// <summary>
        /// Action involves changes to processes or workflows.
        /// </summary>
        ProcessChange,
        /// <summary>
        /// Action involves recognition or reward.
        /// </summary>
        Recognition,
        /// <summary>
        /// Action involves investigation of the issue.
        /// </summary>
        Investigation,
        /// <summary>
        /// Action involves follow-up activities.
        /// </summary>
        Follow_up
    }
}
