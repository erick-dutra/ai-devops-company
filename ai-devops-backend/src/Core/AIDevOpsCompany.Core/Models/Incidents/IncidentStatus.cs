namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the status of an incident.
    /// </summary>
    public enum IncidentStatus
    {
        /// <summary>Incident is open.</summary>
        Open,
        /// <summary>Incident has been acknowledged.</summary>
        Acknowledged,
        /// <summary>Incident is in progress.</summary>
        InProgress,
        /// <summary>Incident has been mitigated.</summary>
        Mitigated,
        /// <summary>Incident has been resolved.</summary>
        Resolved,
        /// <summary>Incident has been closed.</summary>
        Closed,
        /// <summary>Incident has been cancelled.</summary>
        Cancelled
    }
}
