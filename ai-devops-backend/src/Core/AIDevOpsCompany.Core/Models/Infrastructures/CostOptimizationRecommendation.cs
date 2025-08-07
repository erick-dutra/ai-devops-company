namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents a recommendation for optimizing infrastructure costs.
    /// </summary>
    public class CostOptimizationRecommendation
    {
        /// <summary>
        /// Unique identifier for the recommendation.
        /// </summary>
        public string RecommendationId { get; set; } = string.Empty;
        /// <summary>
        /// Type of cost optimization.
        /// </summary>
        public CostOptimizationType Type { get; set; }
        /// <summary>
        /// Description of the recommendation.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Potential savings if the recommendation is implemented.
        /// </summary>
        public decimal PotentialSavings { get; set; }
        /// <summary>
        /// Impact of the recommendation.
        /// </summary>
        public string Impact { get; set; } = string.Empty;
        /// <summary>
        /// Implementation details for the recommendation.
        /// </summary>
        public string Implementation { get; set; } = string.Empty;
    }
}
