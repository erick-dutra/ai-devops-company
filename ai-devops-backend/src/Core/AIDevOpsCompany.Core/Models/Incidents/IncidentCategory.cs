namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the category of an incident.
    /// </summary>
    public enum IncidentCategory
    {
        /// <summary>Application-related incident.</summary>
        Application,
        /// <summary>Infrastructure-related incident.</summary>
        Infrastructure,
        /// <summary>Network-related incident.</summary>
        Network,
        /// <summary>Database-related incident.</summary>
        Database,
        /// <summary>Security-related incident.</summary>
        Security,
        /// <summary>Performance-related incident.</summary>
        Performance,
        /// <summary>Availability-related incident.</summary>
        Availability,
        /// <summary>Data loss incident.</summary>
        DataLoss,
        /// <summary>Configuration-related incident.</summary>
        Configuration,
        /// <summary>Third-party service incident.</summary>
        ThirdParty
    }
}
