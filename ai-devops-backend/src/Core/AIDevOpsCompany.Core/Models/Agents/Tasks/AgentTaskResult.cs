namespace AIDevOpsCompany.Core.Models.Agents.Tasks
{
    /// <summary>
    /// Represents the result of an agent's task execution.
    /// </summary>
    public class AgentTaskResult
    {
        /// <summary>
        /// Indicates if the task was successful.
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Message describing the result.
        /// </summary>
        public string Message { get; set; } = string.Empty;
        /// <summary>
        /// Additional data returned by the task.
        /// </summary>
        public Dictionary<string, object> Data { get; set; } = new();
    }
}