namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a suggested improvement derived from quality testing results.
    /// </summary>
    public class QualityRecommendation
    {
        /// <summary>
        /// Unique identifier for the recommendation.
        /// </summary>
        public string RecommendationId { get; set; } = string.Empty;
        
        /// <summary>
        /// Type of the quality recommendation (e.g., TestCoverage, Performance, Security).
        /// </summary>
        public QualityRecommendationType Type { get; set; }
        
        /// <summary>
        /// Priority level for implementing the recommendation.
        /// </summary>
        public QualityRecommendationPriority Priority { get; set; }
        
        /// <summary>
        /// Detailed description of the recommendation.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        
        /// <summary>
        /// Explanation of why this recommendation is important.
        /// </summary>
        public string Rationale { get; set; } = string.Empty;
        
        /// <summary>
        /// Estimated time required to implement the recommendation.
        /// </summary>
        public TimeSpan EstimatedEffort { get; set; }
        
        /// <summary>
        /// List of system areas affected by this recommendation.
        /// </summary>
        public List<string> AffectedAreas { get; set; } = new();
    }
}
