namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a notification rule for pipeline events, including recipients and conditions.
    /// </summary>
    public class NotificationRule
    {
        /// <summary>
        /// Gets or sets the unique identifier for the notification rule.
        /// </summary>
        public string RuleId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the list of pipeline events that trigger this rule.
        /// </summary>
        public List<PipelineEvent> Events { get; set; } = new();
        /// <summary>
        /// Gets or sets the list of recipients for the notification.
        /// </summary>
        public List<string> Recipients { get; set; } = new();
        /// <summary>
        /// Gets or sets the notification channel to use.
        /// </summary>
        public NotificationChannel Channel { get; set; }
        /// <summary>
        /// Gets or sets the template for the notification message.
        /// </summary>
        public string Template { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets additional conditions for triggering the notification.
        /// </summary>
        public Dictionary<string, object> Conditions { get; set; } = new();
    }
}
