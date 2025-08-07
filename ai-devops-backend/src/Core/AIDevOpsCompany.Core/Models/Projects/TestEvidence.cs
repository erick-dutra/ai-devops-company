namespace AIDevOpsCompany.Core.Models.Projects
{
    /// <summary>
    /// Represents evidence of a test execution for a code version.
    /// </summary>
    public class TestEvidence
    {
        /// <summary>
        /// Unique identifier for the test evidence.
        /// </summary>
        public string EvidenceId { get; set; } = string.Empty;
        
        /// <summary>
        /// Type of the test that was executed.
        /// </summary>
        public TestType TestType { get; set; }
        
        /// <summary>
        /// Name of the test.
        /// </summary>
        public string TestName { get; set; } = string.Empty;
        
        /// <summary>
        /// Result of the test execution.
        /// </summary>
        public TestResult Result { get; set; }
        
        /// <summary>
        /// Detailed description of the test execution.
        /// </summary>
        public string Details { get; set; } = string.Empty;
        
        /// <summary>
        /// Screenshots captured during test execution.
        /// </summary>
        public byte[] Screenshots { get; set; } = Array.Empty<byte>();
        
        /// <summary>
        /// Log files generated during test execution.
        /// </summary>
        public byte[] LogFiles { get; set; } = Array.Empty<byte>();
        
        /// <summary>
        /// Time taken to execute the test.
        /// </summary>
        public TimeSpan ExecutionTime { get; set; }
        
        /// <summary>
        /// When the test was executed.
        /// </summary>
        public DateTime ExecutedAt { get; set; } = DateTime.UtcNow;
        
        /// <summary>
        /// Identifier of the agent that executed the test.
        /// </summary>
        public string ExecutedByAgentId { get; set; } = string.Empty;
        
        /// <summary>
        /// Additional metrics related to the test execution.
        /// </summary>
        public Dictionary<string, object> Metrics { get; set; } = new();
    }
}
