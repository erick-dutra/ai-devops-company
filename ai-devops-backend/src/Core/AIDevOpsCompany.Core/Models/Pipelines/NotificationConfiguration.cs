namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents the configuration for pipeline notifications, including rules and recipients.
    /// </summary>
    public class NotificationConfiguration
    {
        /// <summary>
        /// Gets or sets a value indicating whether notifications are enabled.
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// Gets or sets the list of notification rules.
        /// </summary>
        public List<NotificationRule> Rules { get; set; } = new();
        /// <summary>
        /// Gets or sets the list of default recipients for notifications.
        /// </summary>
        public List<string> DefaultRecipients { get; set; } = new();
    }
}
