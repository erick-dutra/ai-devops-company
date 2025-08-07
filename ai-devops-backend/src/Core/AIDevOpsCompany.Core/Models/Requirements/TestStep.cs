namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Represents a single step in a test case, including the action and expected result.
    /// </summary>
    public class TestStep
    {
        /// <summary>
        /// Gets or sets the step number in the test case.
        /// </summary>
        public int StepNumber { get; set; }
        /// <summary>
        /// Gets or sets the action to be performed in this step.
        /// </summary>
        public string Action { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the expected result of this step.
        /// </summary>
        public string ExpectedResult { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the test data for this step.
        /// </summary>
        public Dictionary<string, object> TestData { get; set; } = new();
    }
}
