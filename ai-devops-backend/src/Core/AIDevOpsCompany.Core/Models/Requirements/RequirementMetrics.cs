namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Represents metrics and complexity information for a requirement.
    /// </summary>
    public class RequirementMetrics
    {
        /// <summary>
        /// Gets or sets the complexity score of the requirement.
        /// </summary>
        public int ComplexityScore { get; set; }
        /// <summary>
        /// Gets or sets the estimated time to implement the requirement.
        /// </summary>
        public TimeSpan EstimatedImplementationTime { get; set; }
        /// <summary>
        /// Gets or sets the number of acceptance criteria.
        /// </summary>
        public int NumberOfAcceptanceCriteria { get; set; }
        /// <summary>
        /// Gets or sets the number of test cases.
        /// </summary>
        public int NumberOfTestCases { get; set; }
        /// <summary>
        /// Gets or sets the number of dependencies.
        /// </summary>
        public int NumberOfDependencies { get; set; }
        /// <summary>
        /// Gets or sets the stability score (how often it changes).
        /// </summary>
        public double StabilityScore { get; set; }
        /// <summary>
        /// Gets or sets custom metrics for the requirement.
        /// </summary>
        public Dictionary<string, object> CustomMetrics { get; set; } = new();
    }
}
