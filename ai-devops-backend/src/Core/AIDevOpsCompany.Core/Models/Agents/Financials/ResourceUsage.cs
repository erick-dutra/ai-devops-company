using AIDevOpsCompany.Core.Models.Infrastructures;

namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents the usage details and cost of a specific resource.
    /// </summary>
    public class ResourceUsage
    {
        /// <summary>
        /// Gets or sets the unique identifier for the usage record.
        /// </summary>
        public string UsageId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier of the resource.
        /// </summary>
        public string ResourceId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        public string ResourceName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the provider of the resource.
        /// </summary>
        public string Provider { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the region where the resource is located.
        /// </summary>
        public string Region { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the usage metrics for the resource.
        /// </summary>
        public UsageMetrics Metrics { get; set; } = new();

        /// <summary>
        /// Gets or sets the cost associated with the resource usage.
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets the currency for the cost.
        /// </summary>
        public string Currency { get; set; } = "USD";

        /// <summary>
        /// Gets or sets the date of the resource usage.
        /// </summary>
        public DateTime UsageDate { get; set; }

        /// <summary>
        /// Gets or sets the billing period for the usage.
        /// </summary>
        public BillingPeriod BillingPeriod { get; set; } = new();

        /// <summary>
        /// Gets or sets additional usage details as key-value pairs.
        /// </summary>
        public Dictionary<string, object> UsageDetails { get; set; } = new();
    }
}
