namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the priority level of an incident.
    /// </summary>
    public enum IncidentPriority
    {
        /// <summary>Critical - immediate response required.</summary>
        P1,
        /// <summary>High - response within 1 hour.</summary>
        P2,
        /// <summary>Medium - response within 4 hours.</summary>
        P3,
        /// <summary>Low - response within 24 hours.</summary>
        P4
    }
}
