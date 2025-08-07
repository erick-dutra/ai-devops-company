namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents profitability metrics for financial analysis.
    /// </summary>
    public class ProfitabilityMetrics
    {
        /// <summary>
        /// Gets or sets the gross profit.
        /// </summary>
        public decimal GrossProfit { get; set; }

        /// <summary>
        /// Gets or sets the net profit.
        /// </summary>
        public decimal NetProfit { get; set; }

        /// <summary>
        /// Gets or sets the gross profit margin.
        /// </summary>
        public decimal GrossProfitMargin { get; set; }

        /// <summary>
        /// Gets or sets the net profit margin.
        /// </summary>
        public decimal NetProfitMargin { get; set; }

        /// <summary>
        /// Gets or sets the EBITDA (Earnings Before Interest, Taxes, Depreciation, and Amortization).
        /// </summary>
        public decimal EBITDA { get; set; }

        /// <summary>
        /// Gets or sets the EBITDA margin.
        /// </summary>
        public decimal EBITDAMargin { get; set; }

        /// <summary>
        /// Gets or sets the return on investment (ROI).
        /// </summary>
        public decimal ReturnOnInvestment { get; set; }

        /// <summary>
        /// Gets or sets the profit per project.
        /// </summary>
        public decimal ProfitPerProject { get; set; }

        /// <summary>
        /// Gets or sets the profit per client.
        /// </summary>
        public decimal ProfitPerClient { get; set; }
    }
}
