namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Represents an acceptance criteria for a requirement, including status and related test cases.
    /// </summary>
    public class AcceptanceCriteria
    {
        /// <summary>
        /// Gets or sets the unique identifier for the acceptance criteria.
        /// </summary>
        public string CriteriaId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description of the acceptance criteria.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the Given-When-Then scenario for the acceptance criteria.
        /// </summary>
        public string GivenWhenThen { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the status of the acceptance criteria.
        /// </summary>
        public AcceptanceCriteriaStatus Status { get; set; } = AcceptanceCriteriaStatus.Pending;
        /// <summary>
        /// Gets or sets the list of test cases related to this acceptance criteria.
        /// </summary>
        public List<TestCase> TestCases { get; set; } = new();
        /// <summary>
        /// Gets or sets the date and time when the acceptance criteria was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the identifier of the agent who created the acceptance criteria.
        /// </summary>
        public string CreatedByAgentId { get; set; } = string.Empty;
    }
}
