namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the trend of an agent's performance over time.
    /// </summary>
    public enum PerformanceTrend
    {
        /// <summary>
        /// Performance is improving.
        /// </summary>
        Improving,
        /// <summary>
        /// Performance is stable.
        /// </summary>
        Stable,
        /// <summary>
        /// Performance is declining.
        /// </summary>
        Declining,
        /// <summary>
        /// Performance is volatile or inconsistent.
        /// </summary>
        Volatile
    }
}
