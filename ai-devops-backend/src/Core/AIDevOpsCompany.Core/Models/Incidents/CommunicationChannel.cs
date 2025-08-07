namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the communication channel used for incident notifications and updates.
    /// </summary>
    public enum CommunicationChannel
    {
        /// <summary>
        /// Email communication channel.
        /// </summary>
        Email,
        /// <summary>
        /// Slack communication channel.
        /// </summary>
        Slack,
        /// <summary>
        /// Microsoft Teams communication channel.
        /// </summary>
        Teams,
        /// <summary>
        /// SMS (Short Message Service) communication channel.
        /// </summary>
        SMS,
        /// <summary>
        /// Phone call communication channel.
        /// </summary>
        Phone,
        /// <summary>
        /// Status page communication channel.
        /// </summary>
        StatusPage,
        /// <summary>
        /// Dashboard communication channel.
        /// </summary>
        Dashboard,
        /// <summary>
        /// Webhook communication channel.
        /// </summary>
        Webhook
    }
}
