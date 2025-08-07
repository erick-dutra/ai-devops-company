namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a billing period, including start/end dates and frequency.
    /// </summary>
    public class BillingPeriod
    {
        /// <summary>
        /// Start date of the billing period.
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// End date of the billing period.
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Frequency of the billing period.
        /// </summary>
        public BillingFrequency Frequency { get; set; }
        /// <summary>
        /// Description of the billing period.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Number of the period within the year.
        /// </summary>
        public int PeriodNumber { get; set; }
        /// <summary>
        /// Year of the billing period.
        /// </summary>
        public int Year { get; set; }
    }
}
