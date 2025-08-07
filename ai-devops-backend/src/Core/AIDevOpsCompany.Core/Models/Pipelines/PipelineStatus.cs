namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Defines the status of a pipeline.
    /// </summary>
    public enum PipelineStatus
    {
        /// <summary>
        /// Pipeline is in draft state.
        /// </summary>
        Draft,
        /// <summary>
        /// Pipeline is active.
        /// </summary>
        Active,
        /// <summary>
        /// Pipeline is paused.
        /// </summary>
        Paused,
        /// <summary>
        /// Pipeline is disabled.
        /// </summary>
        Disabled,
        /// <summary>
        /// Pipeline is deleted.
        /// </summary>
        Deleted
    }
}
