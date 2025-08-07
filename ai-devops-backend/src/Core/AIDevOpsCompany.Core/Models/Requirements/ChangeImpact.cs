namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Represents the impact of a change on requirements, test cases, and code components.
    /// </summary>
    public class ChangeImpact
    {
        /// <summary>
        /// Gets or sets the list of affected requirements.
        /// </summary>
        public List<string> AffectedRequirements { get; set; } = new();
        /// <summary>
        /// Gets or sets the list of affected test cases.
        /// </summary>
        public List<string> AffectedTestCases { get; set; } = new();
        /// <summary>
        /// Gets or sets the list of affected code components.
        /// </summary>
        public List<string> AffectedCodeComponents { get; set; } = new();
        /// <summary>
        /// Gets or sets the estimated effort required for the change.
        /// </summary>
        public TimeSpan EstimatedEffort { get; set; }
        /// <summary>
        /// Gets or sets the estimated cost of the change.
        /// </summary>
        public decimal EstimatedCost { get; set; }
        /// <summary>
        /// Gets or sets the description of the impact.
        /// </summary>
        public string ImpactDescription { get; set; } = string.Empty;
    }
}
