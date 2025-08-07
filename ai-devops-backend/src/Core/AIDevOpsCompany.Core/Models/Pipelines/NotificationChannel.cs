namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Defines the channels available for pipeline notifications.
    /// </summary>
    public enum NotificationChannel
    {
        /// <summary>
        /// Email notification.
        /// </summary>
        Email,
        /// <summary>
        /// Slack notification.
        /// </summary>
        Slack,
        /// <summary>
        /// Microsoft Teams notification.
        /// </summary>
        Teams,
        /// <summary>
        /// Webhook notification.
        /// </summary>
        Webhook,
        /// <summary>
        /// SMS notification.
        /// </summary>
        SMS
    }
}
