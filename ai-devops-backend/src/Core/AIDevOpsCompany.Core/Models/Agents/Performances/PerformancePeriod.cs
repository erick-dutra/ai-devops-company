namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents a period of time for performance evaluation.
    /// </summary>
    public class PerformancePeriod
    {
        /// <summary>
        /// Start date of the performance period.
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// End date of the performance period.
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Type of the performance period (e.g., monthly, quarterly).
        /// </summary>
        public PerformancePeriodType Type { get; set; }
        /// <summary>
        /// Description of the performance period.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Number of the period within the year (e.g., quarter number).
        /// </summary>
        public int PeriodNumber { get; set; }
        /// <summary>
        /// Year of the performance period.
        /// </summary>
        public int Year { get; set; }
    }
}
