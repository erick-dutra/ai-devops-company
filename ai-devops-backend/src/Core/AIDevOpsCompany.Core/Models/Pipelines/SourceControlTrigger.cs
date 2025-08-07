namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a trigger based on source control changes.
    /// </summary>
    public class SourceControlTrigger
    {
        /// <summary>
        /// Branches to monitor for changes.
        /// </summary>
        public List<string> Branches { get; set; } = new();
        /// <summary>
        /// Paths to include for monitoring.
        /// </summary>
        public List<string> Paths { get; set; } = new();
        /// <summary>
        /// Paths to exclude from monitoring.
        /// </summary>
        public List<string> ExcludePaths { get; set; } = new();
        /// <summary>
        /// Whether to batch changes.
        /// </summary>
        public bool BatchChanges { get; set; }
        /// <summary>
        /// Maximum concurrent builds allowed.
        /// </summary>
        public int MaxConcurrentBuilds { get; set; }
    }
}
