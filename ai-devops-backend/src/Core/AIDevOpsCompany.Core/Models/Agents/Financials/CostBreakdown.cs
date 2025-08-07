namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a detailed breakdown of a specific cost, including category, type, and details.
    /// </summary>
    public class CostBreakdown
    {
        /// <summary>
        /// Gets or sets the unique identifier for the cost breakdown entry.
        /// </summary>
        public string BreakdownId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the category of the cost.
        /// </summary>
        public CostCategory Category { get; set; }

        /// <summary>
        /// Gets or sets the description of the cost breakdown.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the amount of the cost.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the currency for the cost amount.
        /// </summary>
        public string Currency { get; set; } = "USD";

        /// <summary>
        /// Gets or sets the type of the cost (e.g., fixed, variable).
        /// </summary>
        public CostType Type { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier associated with the cost.
        /// </summary>
        public string ResourceId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the agent identifier associated with the cost.
        /// </summary>
        public string AgentId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date and time when the cost was incurred.
        /// </summary>
        public DateTime IncurredAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets additional details for the cost breakdown.
        /// </summary>
        public Dictionary<string, object> Details { get; set; } = new();
    }
}
