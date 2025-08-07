namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the type of a process gap identified during a post-incident review.
    /// </summary>
    public enum ProcessGapType
    {
        /// <summary>Gap in detection process.</summary>
        Detection,
        /// <summary>Gap in response process.</summary>
        Response,
        /// <summary>Gap in communication process.</summary>
        Communication,
        /// <summary>Gap in escalation process.</summary>
        Escalation,
        /// <summary>Gap in documentation process.</summary>
        Documentation,
        /// <summary>Gap in training process.</summary>
        Training,
        /// <summary>Gap in tooling process.</summary>
        Tooling,
        /// <summary>Gap in monitoring process.</summary>
        Monitoring
    }
}
