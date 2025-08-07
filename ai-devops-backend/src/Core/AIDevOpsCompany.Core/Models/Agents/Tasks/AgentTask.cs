namespace AIDevOpsCompany.Core.Models.Agents.Tasks
{
    /// <summary>
    /// Represents a task assigned to an agent.
    /// </summary>
    public class AgentTask
    {
        /// <summary>
        /// Unique identifier for the task.
        /// </summary>
        public string TaskId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the related project.
        /// </summary>
        public string ProjectId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the agent to whom the task is assigned.
        /// </summary>
        public string AssignedToAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Type of the task.
        /// </summary>
        public TaskType TaskType { get; set; }
        /// <summary>
        /// Description of the task.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Parameters required for the task.
        /// </summary>
        public Dictionary<string, object> Parameters { get; set; } = new();
        /// <summary>
        /// Current status of the task.
        /// </summary>
        public Commons.TaskStatus Status { get; set; }
        /// <summary>
        /// Date and time when the task was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Date and time when the task was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
    }
}

