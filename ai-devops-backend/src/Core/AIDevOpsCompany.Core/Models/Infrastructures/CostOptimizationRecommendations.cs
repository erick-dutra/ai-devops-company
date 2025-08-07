namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents a collection of cost optimization recommendations and summary savings.
    /// </summary>
    public class CostOptimizationRecommendations
    {
        /// <summary>
        /// List of cost optimization recommendations.
        /// </summary>
        public List<CostOptimizationRecommendation> Recommendations { get; set; } = new();
        /// <summary>
        /// Potential monthly savings if all recommendations are implemented.
        /// </summary>
        public decimal PotentialMonthlySavings { get; set; }
        /// <summary>
        /// Percentage of savings relative to current costs.
        /// </summary>
        public double SavingsPercentage { get; set; }
    }
}
