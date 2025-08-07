namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the type of a performance period.
    /// </summary>
    public enum PerformancePeriodType
    {
        /// <summary>
        /// Daily performance period.
        /// </summary>
        Daily,
        /// <summary>
        /// Weekly performance period.
        /// </summary>
        Weekly,
        /// <summary>
        /// Monthly performance period.
        /// </summary>
        Monthly,
        /// <summary>
        /// Quarterly performance period.
        /// </summary>
        Quarterly,
        /// <summary>
        /// Yearly performance period.
        /// </summary>
        Yearly,
        /// <summary>
        /// Custom-defined performance period.
        /// </summary>
        Custom
    }
}
