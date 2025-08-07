namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a trigger based on the completion of dependent pipelines and branches.
    /// </summary>
    public class DependencyTrigger
    {
        /// <summary>
        /// List of pipeline IDs that this trigger depends on.
        /// </summary>
        public List<string> DependentPipelines { get; set; } = new();
        /// <summary>
        /// Indicates if successful completion is required for the trigger.
        /// </summary>
        public bool RequireSuccessfulCompletion { get; set; }
        /// <summary>
        /// List of branches to monitor for dependency completion.
        /// </summary>
        public List<string> Branches { get; set; } = new();
    }
}
