namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Specifies the type of condition for pipeline steps, jobs, or stages.
    /// </summary>
    public enum ConditionType
    {
        /// <summary>
        /// Always execute regardless of previous results.
        /// </summary>
        Always,
        /// <summary>
        /// Execute only if previous steps succeeded.
        /// </summary>
        OnSuccess,
        /// <summary>
        /// Execute only if previous steps failed.
        /// </summary>
        OnFailure,
        /// <summary>
        /// Execute only if the pipeline was cancelled.
        /// </summary>
        OnCancellation,
        /// <summary>
        /// Execute based on a custom expression or logic.
        /// </summary>
        Custom,
        /// <summary>
        /// Never execute.
        /// </summary>
        Never
    }
}
