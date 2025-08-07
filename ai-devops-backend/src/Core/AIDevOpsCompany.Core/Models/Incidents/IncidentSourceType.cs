namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the type of the incident source.
    /// </summary>
    public enum IncidentSourceType
    {
        /// <summary>Incident detected by monitoring.</summary>
        Monitoring,
        /// <summary>Incident reported by a user.</summary>
        User,
        /// <summary>Incident reported by an agent.</summary>
        Agent,
        /// <summary>Incident detected by automated test.</summary>
        AutomatedTest,
        /// <summary>Incident detected by security scan.</summary>
        SecurityScan,
        /// <summary>Incident detected by health check.</summary>
        HealthCheck,
        /// <summary>Incident reported manually.</summary>
        Manual
    }
}
