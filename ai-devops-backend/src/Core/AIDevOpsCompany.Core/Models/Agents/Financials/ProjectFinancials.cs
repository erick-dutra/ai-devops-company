namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents financial metrics and status for a project.
    /// </summary>
    public class ProjectFinancials
    {
        /// <summary>
        /// Gets or sets the unique identifier for the project.
        /// </summary>
        public string ProjectId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        public string ProjectName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the total revenue for the project.
        /// </summary>
        public decimal Revenue { get; set; }

        /// <summary>
        /// Gets or sets the total costs for the project.
        /// </summary>
        public decimal Costs { get; set; }

        /// <summary>
        /// Gets or sets the profit for the project.
        /// </summary>
        public decimal Profit { get; set; }

        /// <summary>
        /// Gets or sets the profit margin for the project.
        /// </summary>
        public decimal ProfitMargin { get; set; }

        /// <summary>
        /// Gets or sets the budget variance for the project.
        /// </summary>
        public decimal BudgetVariance { get; set; }

        /// <summary>
        /// Gets or sets the time variance for the project.
        /// </summary>
        public decimal TimeVariance { get; set; }

        /// <summary>
        /// Gets or sets the financial status of the project.
        /// </summary>
        public ProjectFinancialStatus Status { get; set; }
    }
}
