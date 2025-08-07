namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the type of action taken to address a performance issue.
    /// </summary>
    public enum PerformanceIssueActionType
    {
        /// <summary>
        /// Action involves training activities.
        /// </summary>
        Training,
        /// <summary>
        /// Action involves coaching or mentoring.
        /// </summary>
        Coaching,
        /// <summary>
        /// Action involves process improvement.
        /// </summary>
        ProcessImprovement,
        /// <summary>
        /// Action involves upgrading tools.
        /// </summary>
        ToolUpgrade,
        /// <summary>
        /// Action involves configuration changes.
        /// </summary>
        ConfigurationChange,
        /// <summary>
        /// Action involves monitoring activities.
        /// </summary>
        Monitoring,
        /// <summary>
        /// Action involves updating or creating documentation.
        /// </summary>
        Documentation
    }
}
