namespace AIDevOpsCompany.Core.Models.Agents.Prompts
{
    /// <summary>
    /// Represents a configurable prompt for an agent.
    /// </summary>
    public class AgentPrompt
    {
        /// <summary>
        /// Unique identifier for the prompt.
        /// </summary>
        public string PromptId { get; set; } = string.Empty;
        /// <summary>
        /// Role of the agent associated with the prompt.
        /// </summary>
        public string AgentRole { get; set; } = string.Empty;
        /// <summary>
        /// Name of the prompt.
        /// </summary>
        public string PromptName { get; set; } = string.Empty;
        /// <summary>
        /// Description of the prompt's purpose.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Content of the prompt, possibly with placeholders for variables.
        /// </summary>
        public string PromptContent { get; set; } = string.Empty;
        /// <summary>
        /// List of variable names expected in the prompt.
        /// </summary>
        public List<string> Variables { get; set; } = new();
        /// <summary>
        /// Version of the prompt for change tracking.
        /// </summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>
        /// Agent who last modified the prompt.
        /// </summary>
        public string LastModifiedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the prompt was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Date and time when the prompt was last updated.
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}

