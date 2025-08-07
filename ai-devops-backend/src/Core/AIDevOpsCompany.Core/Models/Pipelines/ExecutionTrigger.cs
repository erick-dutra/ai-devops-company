namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents the trigger information for a pipeline execution, including type, source, and data.
    /// </summary>
    public class ExecutionTrigger
    {
        /// <summary>
        /// Type of the trigger (e.g., manual, schedule, webhook).
        /// </summary>
        public TriggerType Type { get; set; }
        /// <summary>
        /// Identifier of the entity or user that triggered the execution.
        /// </summary>
        public string TriggeredBy { get; set; } = string.Empty;
        /// <summary>
        /// Reason for triggering the execution.
        /// </summary>
        public string Reason { get; set; } = string.Empty;
        /// <summary>
        /// Source version associated with the trigger.
        /// </summary>
        public string SourceVersion { get; set; } = string.Empty;
        /// <summary>
        /// Source branch associated with the trigger.
        /// </summary>
        public string SourceBranch { get; set; } = string.Empty;
        /// <summary>
        /// Additional trigger data or metadata.
        /// </summary>
        public Dictionary<string, object> TriggerData { get; set; } = new();
    }
}
