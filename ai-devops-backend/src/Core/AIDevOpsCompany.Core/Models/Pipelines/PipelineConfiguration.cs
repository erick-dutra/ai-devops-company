using AIDevOpsCompany.Core.Models.Infrastructures;

namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents the configuration settings for a pipeline, including agent, pool, resources, notifications, security, and retention policy.
    /// </summary>
    public class PipelineConfiguration
    {
        /// <summary>
        /// Name or identifier of the agent to run the pipeline.
        /// </summary>
        public string Agent { get; set; } = string.Empty;
        /// <summary>
        /// Name of the agent pool.
        /// </summary>
        public string Pool { get; set; } = string.Empty;
        /// <summary>
        /// List of demands or requirements for the agent.
        /// </summary>
        public List<string> Demands { get; set; } = new();
        /// <summary>
        /// Variables and parameters for the pipeline.
        /// </summary>
        public Dictionary<string, string> Variables { get; set; } = new();
        /// <summary>
        /// List of resources required by the pipeline.
        /// </summary>
        public List<PipelineResource> Resources { get; set; } = new();
        /// <summary>
        /// Notification configuration for the pipeline.
        /// </summary>
        public NotificationConfiguration Notifications { get; set; } = new();
        /// <summary>
        /// Security configuration for the pipeline.
        /// </summary>
        public SecurityConfiguration Security { get; set; } = new();
        /// <summary>
        /// Retention policy for pipeline runs and artifacts.
        /// </summary>
        public RetentionPolicy Retention { get; set; } = new();
    }
}
