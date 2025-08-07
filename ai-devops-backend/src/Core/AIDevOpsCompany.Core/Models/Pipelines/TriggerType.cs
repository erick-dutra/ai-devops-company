namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Defines the types of triggers available for pipeline execution.
    /// </summary>
    public enum TriggerType
    {
        /// <summary>
        /// Triggered manually by a user.
        /// </summary>
        Manual,
        /// <summary>
        /// Triggered by a scheduled time.
        /// </summary>
        Schedule,
        /// <summary>
        /// Triggered by source control changes.
        /// </summary>
        SourceControl,
        /// <summary>
        /// Triggered by a webhook event.
        /// </summary>
        Webhook,
        /// <summary>
        /// Triggered by a dependency completion.
        /// </summary>
        Dependency,
        /// <summary>
        /// Triggered via API call.
        /// </summary>
        API
    }
}
