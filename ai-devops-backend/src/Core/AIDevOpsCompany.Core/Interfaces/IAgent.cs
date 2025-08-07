using AIDevOpsCompany.Core.Models.Agents.Messages;
using AIDevOpsCompany.Core.Models.Agents.Tasks;

namespace AIDevOpsCompany.Core.Interfaces
{
    /// <summary>
    /// Represents a generic agent interface for all AI DevOps agents.
    /// </summary>
    public interface IAgent
    {
        /// <summary>
        /// Gets the unique identifier for the agent.
        /// </summary>
        string AgentId { get; }
        /// <summary>
        /// Gets the role of the agent.
        /// </summary>
        string AgentRole { get; }
        /// <summary>
        /// Processes a given agent task asynchronously.
        /// </summary>
        /// <param name="task">The agent task to process.</param>
        /// <returns>True if the task was processed successfully; otherwise, false.</returns>
        Task<bool> ProcessTaskAsync(AgentTask task);
        /// <summary>
        /// Executes a prompt with the specified name and variables.
        /// </summary>
        /// <param name="promptName">The name of the prompt to execute.</param>
        /// <param name="variables">The variables to use in the prompt.</param>
        /// <returns>The result of the executed prompt as a string.</returns>
        Task<string> ExecutePromptAsync(string promptName, Dictionary<string, object> variables);
        /// <summary>
        /// Notifies another agent asynchronously.
        /// </summary>
        /// <param name="targetAgentId">The target agent's unique identifier.</param>
        /// <param name="message">The message to send to the target agent.</param>
        Task NotifyAgentAsync(string targetAgentId, AgentMessage message);
        /// <summary>
        /// Receives a notification from another agent asynchronously.
        /// </summary>
        /// <param name="message">The message received from another agent.</param>
        Task ReceiveNotificationAsync(AgentMessage message);
    }
}

