namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the status of an incident communication.
    /// </summary>
    public enum CommunicationStatus
    {
        /// <summary>Communication is in draft state.</summary>
        Draft,
        /// <summary>Communication has been sent.</summary>
        Sent,
        /// <summary>Communication has been delivered.</summary>
        Delivered,
        /// <summary>Communication failed to send or deliver.</summary>
        Failed,
        /// <summary>Communication was cancelled.</summary>
        Cancelled
    }
}
