namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Defines the types of communications that can occur during an incident lifecycle.
    /// </summary>
    public enum CommunicationType
    {
        /// <summary>
        /// Communication providing a status update.
        /// </summary>
        StatusUpdate,
        /// <summary>
        /// Initial notification about the incident.
        /// </summary>
        InitialNotification,
        /// <summary>
        /// Communication regarding escalation of the incident.
        /// </summary>
        Escalation,
        /// <summary>
        /// Communication about the resolution of the incident.
        /// </summary>
        Resolution,
        /// <summary>
        /// Post-mortem communication after incident closure.
        /// </summary>
        PostMortem,
        /// <summary>
        /// Notification sent to users.
        /// </summary>
        UserNotification,
        /// <summary>
        /// Update sent to stakeholders.
        /// </summary>
        StakeholderUpdate
    }
}
