namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Defines the types of jobs that can be executed in a pipeline.
    /// </summary>
    public enum JobType
    {
        /// <summary>
        /// Build job.
        /// </summary>
        Build,
        /// <summary>
        /// Test job.
        /// </summary>
        Test,
        /// <summary>
        /// Deployment job.
        /// </summary>
        Deploy,
        /// <summary>
        /// Script execution job.
        /// </summary>
        Script,
        /// <summary>
        /// Custom job type.
        /// </summary>
        Custom
    }
}
