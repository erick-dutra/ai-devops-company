namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the type of impact caused by an incident.
    /// </summary>
    public enum ImpactType
    {
        /// <summary>Service is unavailable.</summary>
        ServiceUnavailable,
        /// <summary>Service is degraded.</summary>
        ServiceDegraded,
        /// <summary>Data loss occurred.</summary>
        DataLoss,
        /// <summary>Security breach occurred.</summary>
        SecurityBreach,
        /// <summary>Performance issue detected.</summary>
        PerformanceIssue,
        /// <summary>Feature is unavailable.</summary>
        FeatureUnavailable,
        /// <summary>User experience is impacted.</summary>
        UserExperienceImpact
    }
}
