namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents cost-related metrics for financial analysis.
    /// </summary>
    public class CostMetrics
    {
        /// <summary>
        /// Gets or sets the total costs.
        /// </summary>
        public decimal TotalCosts { get; set; }

        /// <summary>
        /// Gets or sets the infrastructure costs.
        /// </summary>
        public decimal InfrastructureCosts { get; set; }

        /// <summary>
        /// Gets or sets the license costs.
        /// </summary>
        public decimal LicenseCosts { get; set; }

        /// <summary>
        /// Gets or sets the operational costs.
        /// </summary>
        public decimal OperationalCosts { get; set; }

        /// <summary>
        /// Gets or sets the development costs.
        /// </summary>
        public decimal DevelopmentCosts { get; set; }

        /// <summary>
        /// Gets or sets the marketing costs.
        /// </summary>
        public decimal MarketingCosts { get; set; }

        /// <summary>
        /// Gets or sets the administrative costs.
        /// </summary>
        public decimal AdministrativeCosts { get; set; }

        /// <summary>
        /// Gets or sets the cost growth rate.
        /// </summary>
        public decimal CostGrowthRate { get; set; }

        /// <summary>
        /// Gets or sets the cost breakdown by category.
        /// </summary>
        public Dictionary<string, decimal> CostsByCategory { get; set; } = new();
    }
}
