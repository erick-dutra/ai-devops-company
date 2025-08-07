using AIDevOpsCompany.Core.Models.Agents.Prompts;

namespace AIDevOpsCompany.Core.Interfaces
{
    /// <summary>
    /// Represents a repository interface for managing agent prompts.
    /// </summary>
    public interface IPromptRepository
    {
        /// <summary>
        /// Gets a specific prompt for an agent asynchronously.
        /// </summary>
        /// <param name="agentRole">The role of the agent.</param>
        /// <param name="promptName">The name of the prompt.</param>
        /// <returns>The agent prompt if found; otherwise, null.</returns>
        Task<AgentPrompt?> GetPromptAsync(string agentRole, string promptName);

        /// <summary>
        /// Gets all prompts for a specific agent asynchronously.
        /// </summary>
        /// <param name="agentRole">The role of the agent.</param>
        /// <returns>A list of prompts for the specified agent.</returns>
        Task<List<AgentPrompt>> GetPromptsForAgentAsync(string agentRole);

        /// <summary>
        /// Saves a new prompt asynchronously.
        /// </summary>
        /// <param name="prompt">The agent prompt to save.</param>
        Task SavePromptAsync(AgentPrompt prompt);

        /// <summary>
        /// Updates an existing prompt asynchronously.
        /// </summary>
        /// <param name="prompt">The agent prompt to update.</param>
        Task UpdatePromptAsync(AgentPrompt prompt);
    }
}

