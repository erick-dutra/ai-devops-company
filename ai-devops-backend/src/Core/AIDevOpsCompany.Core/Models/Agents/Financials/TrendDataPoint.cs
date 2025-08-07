namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a single data point in a trend analysis, including date, value, and label.
    /// </summary>
    public class TrendDataPoint
    {
        /// <summary>
        /// Date of the data point.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Value at the given date.
        /// </summary>
        public decimal Value { get; set; }
        /// <summary>
        /// Optional label for the data point.
        /// </summary>
        public string Label { get; set; } = string.Empty;
    }
}
