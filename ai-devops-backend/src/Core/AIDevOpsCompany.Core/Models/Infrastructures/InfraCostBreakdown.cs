namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents a breakdown of infrastructure costs by resource, including type, name, and pricing details.
    /// </summary>
    public class InfraCostBreakdown
    {
        /// <summary>
        /// Type of the resource (e.g., VM, Storage).
        /// </summary>
        public string ResourceType { get; set; } = string.Empty;
        /// <summary>
        /// Name of the resource.
        /// </summary>
        public string ResourceName { get; set; } = string.Empty;
        /// <summary>
        /// Hourly cost of the resource.
        /// </summary>
        public decimal HourlyCost { get; set; }
        /// <summary>
        /// Monthly cost of the resource.
        /// </summary>
        public decimal MonthlyCost { get; set; }
        /// <summary>
        /// Pricing model used (e.g., OnDemand, Reserved).
        /// </summary>
        public string PricingModel { get; set; } = string.Empty;
        /// <summary>
        /// Additional cost factors for the resource.
        /// </summary>
        public Dictionary<string, object> CostFactors { get; set; } = new();
    }
}
