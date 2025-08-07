namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents the retention policy for pipeline runs and artifacts.
    /// </summary>
    public class RetentionPolicy
    {
        /// <summary>
        /// Number of days to keep pipeline runs.
        /// </summary>
        public int DaysToKeepRuns { get; set; }
        /// <summary>
        /// Number of pipeline runs to keep.
        /// </summary>
        public int RunsToKeep { get; set; }
        /// <summary>
        /// Number of days to keep artifacts.
        /// </summary>
        public int DaysToKeepArtifacts { get; set; }
        /// <summary>
        /// Whether to delete the source branch.
        /// </summary>
        public bool DeleteSourceBranch { get; set; }
    }
}
