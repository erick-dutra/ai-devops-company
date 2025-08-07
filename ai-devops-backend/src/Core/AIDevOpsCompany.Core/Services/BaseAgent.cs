using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using AIDevOpsCompany.Core.Interfaces;
using Microsoft.Extensions.Logging;
using AIDevOpsCompany.Core.Models.Agents.Messages;
using AIDevOpsCompany.Core.Models.Agents.Tasks;

namespace AIDevOpsCompany.Core.Services
{
    /// <summary>
    /// Abstract base class for AI agents, providing core services such as prompt execution, messaging, and task processing.
    /// </summary>
    public abstract class BaseAgent : IAgent
    {
        /// <summary>
        /// The semantic kernel used for AI operations.
        /// </summary>
        protected readonly Kernel _kernel;
        /// <summary>
        /// Repository for retrieving prompt templates.
        /// </summary>
        protected readonly IPromptRepository _promptRepository;
        /// <summary>
        /// Message broker for agent communication.
        /// </summary>
        protected readonly IMessageBroker _messageBroker;
        /// <summary>
        /// Logger for agent operations.
        /// </summary>
        protected readonly ILogger _logger;

        /// <summary>
        /// Gets the unique identifier of the agent.
        /// </summary>
        public abstract string AgentId { get; }
        /// <summary>
        /// Gets the role of the agent.
        /// </summary>
        public abstract string AgentRole { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseAgent"/> class.
        /// </summary>
        /// <param name="kernel">The semantic kernel for AI operations.</param>
        /// <param name="promptRepository">The prompt repository.</param>
        /// <param name="messageBroker">The message broker for communication.</param>
        /// <param name="logger">The logger instance.</param>
        protected BaseAgent(
            Kernel kernel,
            IPromptRepository promptRepository,
            IMessageBroker messageBroker,
            ILogger logger)
        {
            _kernel = kernel;
            _promptRepository = promptRepository;
            _messageBroker = messageBroker;
            _logger = logger;
        }

        /// <summary>
        /// Processes an agent task asynchronously.
        /// </summary>
        /// <param name="task">The agent task to process.</param>
        /// <returns>True if the task was processed successfully; otherwise, false.</returns>
        public abstract Task<bool> ProcessTaskAsync(AgentTask task);

        /// <summary>
        /// Executes a named prompt with the provided variables and returns the result.
        /// </summary>
        /// <param name="promptName">The name of the prompt to execute.</param>
        /// <param name="variables">Variables to inject into the prompt.</param>
        /// <returns>The result of the prompt execution.</returns>
        public virtual async Task<string> ExecutePromptAsync(string promptName, Dictionary<string, object> variables)
        {
            try
            {
                var prompt = await _promptRepository.GetPromptAsync(AgentRole, promptName);
                if (prompt == null)
                {
                    throw new InvalidOperationException($"Prompt '{promptName}' not found for agent role '{AgentRole}'");
                }

                var processedPrompt = ProcessPromptVariables(prompt.PromptContent, variables);
                
                var chatCompletionService = _kernel.GetRequiredService<IChatCompletionService>();
                var result = await chatCompletionService.GetChatMessageContentAsync(processedPrompt);
                
                return result.Content ?? string.Empty;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error executing prompt {PromptName} for agent {AgentRole}", promptName, AgentRole);
                throw;
            }
        }

        /// <summary>
        /// Sends a notification message to another agent asynchronously.
        /// </summary>
        /// <param name="targetAgentId">The target agent's identifier.</param>
        /// <param name="message">The message to send.</param>
        public virtual async Task NotifyAgentAsync(string targetAgentId, AgentMessage message)
        {
            message.FromAgentId = AgentId;
            message.ToAgentId = targetAgentId;
            message.Timestamp = DateTime.UtcNow;
            
            await _messageBroker.PublishAsync(message);
        }

        /// <summary>
        /// Processes variables in a prompt template and replaces placeholders with actual values.
        /// </summary>
        /// <param name="promptContent">The prompt template content.</param>
        /// <param name="variables">Variables to inject into the prompt.</param>
        /// <returns>The processed prompt string.</returns>
        protected virtual string ProcessPromptVariables(string promptContent, Dictionary<string, object> variables)
        {
            var processedPrompt = promptContent;
            
            foreach (var variable in variables)
            {
                var placeholder = $"{{{variable.Key}}}";
                processedPrompt = processedPrompt.Replace(placeholder, variable.Value?.ToString() ?? string.Empty);
            }
            
            return processedPrompt;
        }

        /// <summary>
        /// Updates the status of a task asynchronously. (To be implemented for MongoDB.)
        /// </summary>
        /// <param name="taskId">The task identifier.</param>
        /// <param name="status">The new status of the task.</param>
        protected virtual async Task UpdateTaskStatusAsync(string taskId, Models.Commons.TaskStatus status)
        {
            // Implementar atualização do status da tarefa no MongoDB
            _logger.LogInformation("Task {TaskId} status updated to {Status}", taskId, status);
            await Task.CompletedTask;
        }

        /// <summary>
        /// Receives a notification message asynchronously. (Not implemented.)
        /// </summary>
        /// <param name="message">The notification message.</param>
        /// <returns>Throws NotImplementedException.</returns>
        public Task ReceiveNotificationAsync(AgentMessage message)
        {
            throw new NotImplementedException();
        }
    }
}

