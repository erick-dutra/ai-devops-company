namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a reporting period with start and end dates and a period type.
    /// </summary>
    public class ReportPeriod
    {
        /// <summary>
        /// Gets or sets the start date of the reporting period.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the reporting period.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the type of the reporting period.
        /// </summary>
        public ReportPeriodType Type { get; set; }

        /// <summary>
        /// Gets or sets the description of the reporting period.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
