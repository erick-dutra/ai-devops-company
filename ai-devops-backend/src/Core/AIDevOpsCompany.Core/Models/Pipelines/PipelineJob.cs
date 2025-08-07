namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a job within a pipeline, including steps, configuration, and dependencies.
    /// </summary>
    public class PipelineJob
    {
        /// <summary>
        /// Unique identifier for the job.
        /// </summary>
        public string JobId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the job.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Description of the job.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of the job.
        /// </summary>
        public JobType Type { get; set; }
        /// <summary>
        /// List of steps to be executed in the job.
        /// </summary>
        public List<JobStep> Steps { get; set; } = new();
        /// <summary>
        /// Configuration settings for the job.
        /// </summary>
        public JobConfiguration Configuration { get; set; } = new();
        /// <summary>
        /// List of job dependencies.
        /// </summary>
        public List<string> Dependencies { get; set; } = new();
        /// <summary>
        /// Condition that must be met for the job to run.
        /// </summary>
        public JobCondition Condition { get; set; } = new();
        /// <summary>
        /// Timeout duration for the job.
        /// </summary>
        public TimeSpan Timeout { get; set; }
        /// <summary>
        /// Number of times the job should be retried on failure.
        /// </summary>
        public int RetryCount { get; set; }
        /// <summary>
        /// Variables and metadata associated with the job.
        /// </summary>
        public Dictionary<string, object> Variables { get; set; } = new();
    }
}
