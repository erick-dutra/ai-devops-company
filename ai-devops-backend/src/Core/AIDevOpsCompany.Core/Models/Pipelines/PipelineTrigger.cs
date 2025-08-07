namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a trigger configuration for a pipeline.
    /// </summary>
    public class PipelineTrigger
    {
        /// <summary>
        /// The type of trigger.
        /// </summary>
        public TriggerType Type { get; set; }
        /// <summary>
        /// Schedule trigger configuration.
        /// </summary>
        public ScheduleTrigger? Schedule { get; set; }
        /// <summary>
        /// Source control trigger configuration.
        /// </summary>
        public SourceControlTrigger? SourceControl { get; set; }
        /// <summary>
        /// Manual trigger configuration.
        /// </summary>
        public ManualTrigger? Manual { get; set; }
        /// <summary>
        /// Webhook trigger configuration.
        /// </summary>
        public WebhookTrigger? Webhook { get; set; }
        /// <summary>
        /// Dependency trigger configuration.
        /// </summary>
        public DependencyTrigger? Dependency { get; set; }
    }
}
