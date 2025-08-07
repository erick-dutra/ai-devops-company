namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Specifies the type of period for financial or usage reports.
    /// </summary>
    public enum ReportPeriodType
    {
        /// <summary>
        /// Daily reporting period.
        /// </summary>
        Daily,
        /// <summary>
        /// Weekly reporting period.
        /// </summary>
        Weekly,
        /// <summary>
        /// Monthly reporting period.
        /// </summary>
        Monthly,
        /// <summary>
        /// Quarterly reporting period.
        /// </summary>
        Quarterly,
        /// <summary>
        /// Yearly reporting period.
        /// </summary>
        Yearly,
        /// <summary>
        /// Custom reporting period.
        /// </summary>
        Custom
    }
}
