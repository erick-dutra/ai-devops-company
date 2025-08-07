namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Represents a test case for validating requirements, including steps, expected results, and executions.
    /// </summary>
    public class TestCase
    {
        /// <summary>
        /// Gets or sets the unique identifier for the test case.
        /// </summary>
        public string TestCaseId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the test case.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description of the test case.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the preconditions required for the test case.
        /// </summary>
        public string Preconditions { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the list of test steps for the test case.
        /// </summary>
        public List<TestStep> Steps { get; set; } = new();
        /// <summary>
        /// Gets or sets the expected result of the test case.
        /// </summary>
        public string ExpectedResult { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the type of the test case.
        /// </summary>
        public TestCaseType Type { get; set; }
        /// <summary>
        /// Gets or sets the priority of the test case.
        /// </summary>
        public TestCasePriority Priority { get; set; }
        /// <summary>
        /// Gets or sets the status of the test case.
        /// </summary>
        public TestCaseStatus Status { get; set; } = TestCaseStatus.Draft;
        /// <summary>
        /// Gets or sets the identifier of the agent who created the test case.
        /// </summary>
        public string CreatedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the date and time when the test case was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the list of executions of the test case.
        /// </summary>
        public List<TestExecution> Executions { get; set; } = new();
    }
}
