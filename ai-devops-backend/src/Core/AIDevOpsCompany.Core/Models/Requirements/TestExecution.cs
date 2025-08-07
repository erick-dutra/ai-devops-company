using AIDevOpsCompany.Core.Models.Projects;

namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Represents the execution of a test case, including results and metadata.
    /// </summary>
    public class TestExecution
    {
        /// <summary>
        /// Gets or sets the unique identifier for the test execution.
        /// </summary>
        public string ExecutionId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the result of the test execution.
        /// </summary>
        public TestResult Result { get; set; }
        /// <summary>
        /// Gets or sets the actual result observed during execution.
        /// </summary>
        public string ActualResult { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets any notes related to the test execution.
        /// </summary>
        public string Notes { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets screenshots captured during execution.
        /// </summary>
        public byte[] Screenshots { get; set; } = Array.Empty<byte>();
        /// <summary>
        /// Gets or sets the time taken to execute the test.
        /// </summary>
        public TimeSpan ExecutionTime { get; set; }
        /// <summary>
        /// Gets or sets the date and time when the test was executed.
        /// </summary>
        public DateTime ExecutedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the identifier of the agent who executed the test.
        /// </summary>
        public string ExecutedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the environment in which the test was executed.
        /// </summary>
        public string Environment { get; set; } = string.Empty;
    }
}
