namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Defines the types of stages in a pipeline.
    /// </summary>
    public enum StageType
    {
        /// <summary>
        /// Build stage.
        /// </summary>
        Build,
        /// <summary>
        /// Test stage.
        /// </summary>
        Test,
        /// <summary>
        /// Deployment stage.
        /// </summary>
        Deploy,
        /// <summary>
        /// Approval stage.
        /// </summary>
        Approval,
        /// <summary>
        /// Custom stage type.
        /// </summary>
        Custom
    }
}
