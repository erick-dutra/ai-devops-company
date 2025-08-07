namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents a cost estimate for infrastructure resources, including breakdown and recommendations.
    /// </summary>
    public class CostEstimate
    {
        /// <summary>
        /// Estimated hourly cost.
        /// </summary>
        public decimal HourlyCost { get; set; }
        /// <summary>
        /// Estimated monthly cost.
        /// </summary>
        public decimal MonthlyCost { get; set; }
        /// <summary>
        /// Estimated yearly cost.
        /// </summary>
        public decimal YearlyCost { get; set; }
        /// <summary>
        /// Cost breakdown by resource or service.
        /// </summary>
        public List<InfraCostBreakdown> Breakdown { get; set; } = new();
        /// <summary>
        /// Currency used for the estimate.
        /// </summary>
        public string Currency { get; set; } = "USD";
        /// <summary>
        /// Date and time when the estimate was generated.
        /// </summary>
        public DateTime EstimatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Cost optimization recommendations.
        /// </summary>
        public CostOptimizationRecommendations Recommendations { get; set; } = new();
    }
}
