namespace AIDevOpsCompany.Core.Models.Agents
{
    /// <summary>
    /// Represents the result of an agent's task execution, including success status, message, and additional data.
    /// </summary>
    internal class AgentTaskResult
    {
        /// <summary>
        /// Indicates if the task was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Message describing the result of the task execution.
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Additional data returned by the task.
        /// </summary>
        public Dictionary<string, object> Data { get; set; } = [];
    }
}