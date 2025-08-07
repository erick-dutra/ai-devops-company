# AI DevOps Backend - Services Documentation

## BaseAgent (Abstract Class)
Abstract base class for AI agents, providing core services such as prompt execution, messaging, and task processing.

| Member                | Type/Signature                                                                 | Description                                                                                 |
|-----------------------|-------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------|
| _kernel               | Kernel                                                                        | The semantic kernel used for AI operations.                                                 |
| _promptRepository     | IPromptRepository                                                              | Repository for retrieving prompt templates.                                                 |
| _messageBroker        | IMessageBroker                                                                 | Message broker for agent communication.                                                     |
| _logger               | ILogger                                                                        | Logger for agent operations.                                                                |
| AgentId               | string (abstract)                                                              | Gets the unique identifier of the agent.                                                    |
| AgentRole             | string (abstract)                                                              | Gets the role of the agent.                                                                 |
| BaseAgent(...)        | Constructor                                                                    | Initializes a new instance of the BaseAgent class.                                          |
| ProcessTaskAsync      | Task<bool> ProcessTaskAsync(AgentTask task) (abstract)                         | Processes an agent task asynchronously.                                                     |
| ExecutePromptAsync    | Task<string> ExecutePromptAsync(string promptName, Dictionary<string, object> variables) | Executes a named prompt with the provided variables and returns the result.                 |
| NotifyAgentAsync      | Task NotifyAgentAsync(string targetAgentId, AgentMessage message)               | Sends a notification message to another agent asynchronously.                               |
| ProcessPromptVariables| string ProcessPromptVariables(string promptContent, Dictionary<string, object> variables) | Processes variables in a prompt template and replaces placeholders with actual values.      |
| UpdateTaskStatusAsync | Task UpdateTaskStatusAsync(string taskId, Models.Commons.TaskStatus status)     | Updates the status of a task asynchronously. (To be implemented for MongoDB.)               |
| ReceiveNotificationAsync | Task ReceiveNotificationAsync(AgentMessage message)                         | Receives a notification message asynchronously. (Not implemented.)                          |

---
