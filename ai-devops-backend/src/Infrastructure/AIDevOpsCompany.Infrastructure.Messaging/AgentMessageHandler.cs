using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Models.Agents.Messages;
using AIDevOpsCompany.Core.Models.Agents.Tasks;
using Microsoft.Extensions.Logging;

namespace AIDevOpsCompany.Infrastructure.Messaging
{
    /// <summary>
    /// Defines methods for handling agent messages, including tasks, events, and notifications.
    /// </summary>
    public interface IAgentMessageHandler
    {
        /// <summary>
        /// Handles a task message sent to an agent.
        /// </summary>
        /// <param name="task">The agent task to process.</param>
        Task HandleTaskMessageAsync(AgentTask task);

        /// <summary>
        /// Handles an event message sent to or from an agent.
        /// </summary>
        /// <param name="message">The event message to process.</param>
        Task HandleEventMessageAsync(AgentMessage message);

        /// <summary>
        /// Handles a notification message sent to agents.
        /// </summary>
        /// <param name="message">The notification message to process.</param>
        Task HandleNotificationMessageAsync(AgentMessage message);
    }

    /// <summary>
    /// Provides an implementation for handling agent messages, including tasks, events, and notifications.
    /// </summary>
    public class AgentMessageHandler : IAgentMessageHandler
    {
        /// <summary>
        /// Logger for logging agent message handling operations.
        /// </summary>
        private readonly ILogger<AgentMessageHandler> _logger;

        /// <summary>
        /// Dictionary of agents indexed by their AgentId.
        /// </summary>
        private readonly Dictionary<string, IAgent> _agents;

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessageHandler"/> class.
        /// </summary>
        /// <param name="logger">The logger instance.</param>
        /// <param name="agents">The collection of agents to manage.</param>
        public AgentMessageHandler(ILogger<AgentMessageHandler> logger, IEnumerable<IAgent> agents)
        {
            _logger = logger;
            _agents = agents.ToDictionary(a => a.AgentId, a => a);
        }

        /// <summary>
        /// Handles a task message sent to an agent.
        /// </summary>
        /// <param name="task">The agent task to process.</param>
        public async Task HandleTaskMessageAsync(AgentTask task)
        {
            try
            {
                _logger.LogInformation("Processing task {TaskId} for agent {AgentId}", task.TaskId, task.AssignedToAgentId);

                if (_agents.TryGetValue(task.AssignedToAgentId, out var agent))
                {
                    await agent.ProcessTaskAsync(task);
                    _logger.LogInformation("Task {TaskId} processed successfully by agent {AgentId}", 
                        task.TaskId, task.AssignedToAgentId);
                }
                else
                {
                    _logger.LogWarning("Agent {AgentId} not found for task {TaskId}", 
                        task.AssignedToAgentId, task.TaskId);
                    
                    // Update task status to failed
                    task.Status = Core.Models.Commons.TaskStatus.Failed;
                    task.CompletedAt = DateTime.UtcNow;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing task {TaskId} for agent {AgentId}", 
                    task.TaskId, task.AssignedToAgentId);
                
                // Update task status to failed
                task.Status = Core.Models.Commons.TaskStatus.Failed;
                task.CompletedAt = DateTime.UtcNow;
                
                throw;
            }
        }

        /// <summary>
        /// Handles an event message sent to or from an agent.
        /// </summary>
        /// <param name="message">The event message to process.</param>
        public async Task HandleEventMessageAsync(AgentMessage message)
        {
            try
            {
                _logger.LogInformation("Processing event message {MessageId} from agent {SenderId}", 
                    message.MessageId, message.FromAgentId);

                // Process different types of events
                switch (message.MessageType)
                {
                    case MessageType.TaskCompleted:
                        await HandleTaskCompletedEvent(message);
                        break;
                    case MessageType.TaskFailed:
                        await HandleTaskFailedEvent(message);
                        break;
                    case MessageType.StatusUpdate:
                        await HandleStatusUpdateEvent(message);
                        break;
                    case MessageType.ErrorReport:
                        await HandleErrorReportEvent(message);
                        break;
                    default:
                        _logger.LogWarning("Unknown message type {MessageType} in message {MessageId}", 
                            message.MessageType, message.MessageId);
                        break;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing event message {MessageId}", message.MessageId);
                throw;
            }
        }

        /// <summary>
        /// Handles a notification message sent to agents.
        /// </summary>
        /// <param name="message">The notification message to process.</param>
        public async Task HandleNotificationMessageAsync(AgentMessage message)
        {
            try
            {
                _logger.LogInformation("Processing notification message {MessageId} from agent {SenderId}", 
                    message.MessageId, message.FromAgentId);

                // Broadcast notification to all relevant agents
                foreach (var agent in _agents.Values)
                {
                    if (agent.AgentId != message.FromAgentId)
                    {
                        await agent.ReceiveNotificationAsync(message);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing notification message {MessageId}", message.MessageId);
                throw;
            }
        }

        /// <summary>
        /// Handles a task completed event message.
        /// </summary>
        /// <param name="message">The event message indicating task completion.</param>
        private async Task HandleTaskCompletedEvent(AgentMessage message)
        {
            _logger.LogInformation("Task completed event received from agent {SenderId}", message.FromAgentId);
            
            // Notify dependent agents or trigger next tasks
            // Implementation depends on business logic
            await Task.CompletedTask;
        }

        /// <summary>
        /// Handles a task failed event message.
        /// </summary>
        /// <param name="message">The event message indicating task failure.</param>
        private async Task HandleTaskFailedEvent(AgentMessage message)
        {
            _logger.LogWarning("Task failed event received from agent {SenderId}: {Content}", 
                message.FromAgentId, message.Content);
            
            // Handle task failure - retry, escalate, or notify
            // Implementation depends on business logic
            await Task.CompletedTask;
        }

        /// <summary>
        /// Handles a status update event message.
        /// </summary>
        /// <param name="message">The event message containing a status update.</param>
        private async Task HandleStatusUpdateEvent(AgentMessage message)
        {
            _logger.LogDebug("Status update received from agent {SenderId}: {Content}", 
                message.FromAgentId, message.Content);
            
            // Update agent status in database or cache
            // Implementation depends on business logic
            await Task.CompletedTask;
        }

        /// <summary>
        /// Handles an error report event message.
        /// </summary>
        /// <param name="message">The event message containing an error report.</param>
        private async Task HandleErrorReportEvent(AgentMessage message)
        {
            _logger.LogError("Error report received from agent {SenderId}: {Content}", 
                message.FromAgentId, message.Content);
            
            // Log error, create incident, or notify administrators
            // Implementation depends on business logic
            await Task.CompletedTask;
        }
    }
}

