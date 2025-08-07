namespace AIDevOpsCompany.Core.Models.Projects
{
    /// <summary>
    /// Represents the current status of a project.
    /// </summary>
    public enum ProjectStatus
    {
        /// <summary>
        /// Project has been initiated but not yet started.
        /// </summary>
        Initiated,
        
        /// <summary>
        /// Project is in the requirements analysis phase.
        /// </summary>
        RequirementsAnalysis,
        
        /// <summary>
        /// Project is actively being developed.
        /// </summary>
        InDevelopment,
        
        /// <summary>
        /// Project is in the testing phase.
        /// </summary>
        Testing,
        
        /// <summary>
        /// Project is in the deployment phase.
        /// </summary>
        Deployment,
        
        /// <summary>
        /// Project has been completed.
        /// </summary>
        Completed,
        
        /// <summary>
        /// Project is temporarily on hold.
        /// </summary>
        OnHold,
        
        /// <summary>
        /// Project has been cancelled.
        /// </summary>
        Cancelled
    }
}
