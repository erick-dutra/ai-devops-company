namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Defines the types of resolutions that can be applied to an incident.
    /// </summary>
    public enum ResolutionType
    {
        /// <summary>
        /// The incident was fixed.
        /// </summary>
        Fixed,
        /// <summary>
        /// A workaround was applied to resolve the incident.
        /// </summary>
        Workaround,
        /// <summary>
        /// The resolution involved a configuration change.
        /// </summary>
        ConfigurationChange,
        /// <summary>
        /// The resolution involved a code fix.
        /// </summary>
        CodeFix,
        /// <summary>
        /// The resolution involved an infrastructure change.
        /// </summary>
        InfrastructureChange,
        /// <summary>
        /// The resolution was provided by a third party.
        /// </summary>
        ThirdPartyFix,
        /// <summary>
        /// The incident was caused by user error.
        /// </summary>
        UserError,
        /// <summary>
        /// The incident was a false alarm.
        /// </summary>
        FalseAlarm,
        /// <summary>
        /// The incident was a duplicate of another incident.
        /// </summary>
        Duplicate
    }
}
