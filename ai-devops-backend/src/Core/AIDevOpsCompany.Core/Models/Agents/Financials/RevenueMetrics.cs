namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents revenue-related metrics for financial analysis.
    /// </summary>
    public class RevenueMetrics
    {
        /// <summary>
        /// Gets or sets the total revenue.
        /// </summary>
        public decimal TotalRevenue { get; set; }

        /// <summary>
        /// Gets or sets the recurring revenue.
        /// </summary>
        public decimal RecurringRevenue { get; set; }

        /// <summary>
        /// Gets or sets the one-time revenue.
        /// </summary>
        public decimal OneTimeRevenue { get; set; }

        /// <summary>
        /// Gets or sets the project-based revenue.
        /// </summary>
        public decimal ProjectRevenue { get; set; }

        /// <summary>
        /// Gets or sets the maintenance revenue.
        /// </summary>
        public decimal MaintenanceRevenue { get; set; }

        /// <summary>
        /// Gets or sets the average value of projects.
        /// </summary>
        public decimal AverageProjectValue { get; set; }

        /// <summary>
        /// Gets or sets the number of projects.
        /// </summary>
        public int NumberOfProjects { get; set; }

        /// <summary>
        /// Gets or sets the revenue growth rate.
        /// </summary>
        public decimal RevenueGrowthRate { get; set; }

        /// <summary>
        /// Gets or sets the revenue breakdown by category.
        /// </summary>
        public Dictionary<string, decimal> RevenueByCategory { get; set; } = new();
    }
}
