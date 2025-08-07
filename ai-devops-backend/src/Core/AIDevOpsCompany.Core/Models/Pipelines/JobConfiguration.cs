namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents configuration settings for a pipeline job.
    /// </summary>
    public class JobConfiguration
    {
        /// <summary>
        /// Agent assigned to the job.
        /// </summary>
        public string Agent { get; set; } = string.Empty;
        /// <summary>
        /// Pool assigned to the job.
        /// </summary>
        public string Pool { get; set; } = string.Empty;
        /// <summary>
        /// List of demands for the job.
        /// </summary>
        public List<string> Demands { get; set; } = new();
        /// <summary>
        /// Variables for the job.
        /// </summary>
        public Dictionary<string, string> Variables { get; set; } = new();
        /// <summary>
        /// Container used for the job.
        /// </summary>
        public string Container { get; set; } = string.Empty;
        /// <summary>
        /// Workspace directory for the job.
        /// </summary>
        public string Workspace { get; set; } = string.Empty;
        /// <summary>
        /// Whether to clean the workspace before run.
        /// </summary>
        public bool CleanWorkspace { get; set; }
    }
}
