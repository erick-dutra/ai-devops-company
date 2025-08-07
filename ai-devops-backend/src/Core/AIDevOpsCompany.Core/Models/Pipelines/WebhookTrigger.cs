namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a webhook trigger configuration for pipeline execution.
    /// </summary>
    public class WebhookTrigger
    {
        /// <summary>
        /// The webhook endpoint URL.
        /// </summary>
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// Secret used to validate webhook requests.
        /// </summary>
        public string Secret { get; set; } = string.Empty;
        /// <summary>
        /// List of events that trigger the webhook.
        /// </summary>
        public List<string> Events { get; set; } = new();
        /// <summary>
        /// Additional filters for webhook events.
        /// </summary>
        public Dictionary<string, object> Filters { get; set; } = new();
    }
}
