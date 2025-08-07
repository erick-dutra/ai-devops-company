namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the type of an action item related to an incident.
    /// </summary>
    public enum ActionItemType
    {
        /// <summary>Process improvement action.</summary>
        ProcessImprovement,
        /// <summary>Tooling enhancement action.</summary>
        ToolingEnhancement,
        /// <summary>Training-related action.</summary>
        Training,
        /// <summary>Documentation-related action.</summary>
        Documentation,
        /// <summary>Monitoring improvement action.</summary>
        MonitoringImprovement,
        /// <summary>Infrastructure change action.</summary>
        InfrastructureChange,
        /// <summary>Code change action.</summary>
        CodeChange,
        /// <summary>Policy change action.</summary>
        PolicyChange
    }
}
