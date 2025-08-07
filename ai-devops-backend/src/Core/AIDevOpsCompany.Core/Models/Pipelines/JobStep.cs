namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a step within a pipeline job, including commands, scripts, and execution settings.
    /// </summary>
    public class JobStep
    {
        /// <summary>
        /// Unique identifier for the step.
        /// </summary>
        public string StepId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the step.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Description of the step.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Order of the step in the job.
        /// </summary>
        public int Order { get; set; }
        /// <summary>
        /// Type of the step.
        /// </summary>
        public StepType Type { get; set; }
        /// <summary>
        /// Command to execute.
        /// </summary>
        public string Command { get; set; } = string.Empty;
        /// <summary>
        /// Script to execute.
        /// </summary>
        public string Script { get; set; } = string.Empty;
        /// <summary>
        /// Arguments for the command or script.
        /// </summary>
        public List<string> Arguments { get; set; } = new();
        /// <summary>
        /// Working directory for the step.
        /// </summary>
        public string WorkingDirectory { get; set; } = string.Empty;
        /// <summary>
        /// Environment variables for the step.
        /// </summary>
        public Dictionary<string, string> Environment { get; set; } = new();
        /// <summary>
        /// Condition that must be met for the step.
        /// </summary>
        public StepCondition Condition { get; set; } = new();
        /// <summary>
        /// Timeout duration for the step.
        /// </summary>
        public TimeSpan Timeout { get; set; }
        /// <summary>
        /// Whether to continue on error.
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// Additional parameters for the step.
        /// </summary>
        public Dictionary<string, object> Parameters { get; set; } = new();
    }
}
