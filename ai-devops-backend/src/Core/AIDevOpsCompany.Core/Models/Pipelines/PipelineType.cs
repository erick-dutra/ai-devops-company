namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Defines the types of pipelines.
    /// </summary>
    public enum PipelineType
    {
        /// <summary>
        /// Build pipeline.
        /// </summary>
        Build,
        /// <summary>
        /// Release pipeline.
        /// </summary>
        Release,
        /// <summary>
        /// Combined build and release pipeline.
        /// </summary>
        BuildAndRelease,
        /// <summary>
        /// Test pipeline.
        /// </summary>
        Test,
        /// <summary>
        /// Deployment pipeline.
        /// </summary>
        Deploy,
        /// <summary>
        /// Custom pipeline type.
        /// </summary>
        Custom
    }
}
