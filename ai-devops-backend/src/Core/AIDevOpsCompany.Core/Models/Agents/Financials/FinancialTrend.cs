namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a financial trend for a specific metric, including data points and analysis.
    /// </summary>
    public class FinancialTrend
    {
        /// <summary>
        /// Gets or sets the name of the metric being analyzed.
        /// </summary>
        public string MetricName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of data points for the trend.
        /// </summary>
        public List<TrendDataPoint> DataPoints { get; set; } = new();

        /// <summary>
        /// Gets or sets the direction of the trend.
        /// </summary>
        public TrendDirection Direction { get; set; }

        /// <summary>
        /// Gets or sets the percentage change for the trend.
        /// </summary>
        public decimal ChangePercentage { get; set; }

        /// <summary>
        /// Gets or sets the analysis or commentary for the trend.
        /// </summary>
        public string Analysis { get; set; } = string.Empty;
    }
}
