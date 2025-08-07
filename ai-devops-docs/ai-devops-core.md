## IAgent

| Member | Type | Description |
|--------|------|-------------|
| AgentId | string | Gets the unique identifier for the agent. |
| AgentRole | string | Gets the role of the agent. |
| ProcessTaskAsync | Method | Processes a given agent task asynchronously. Returns true if the task was processed successfully. |
| ExecutePromptAsync | Method | Executes a prompt with the specified name and variables. Returns the result as a string. |
| NotifyAgentAsync | Method | Notifies another agent asynchronously. |
| ReceiveNotificationAsync | Method | Receives a notification from another agent asynchronously. |

**Namespace:** `AIDevOpsCompany.Core.Interfaces`

---

## IDevelopmentTaskRepository

| Member | Type | Description |
|--------|------|-------------|
| GetByIdAsync | Method | Gets a development task by its unique identifier asynchronously. Returns the development task if found; otherwise, null. |
| GetAllAsync | Method | Gets all development tasks asynchronously. Returns a list of all development tasks. |
| CreateAsync | Method | Creates a new development task asynchronously. |
| UpdateAsync | Method | Updates an existing development task asynchronously. |
| DeleteAsync | Method | Deletes a development task by its unique identifier asynchronously. |
| GetByProjectIdAsync | Method | Gets all development tasks by project identifier asynchronously. Returns a list of development tasks for the specified project. |
| GetByStatusAsync | Method | Gets all development tasks by their status asynchronously. Returns a list of development tasks with the specified status. |

**Namespace:** `AIDevOpsCompany.Core.Interfaces`

---

## IMessageBroker

| Member | Type | Description |
|--------|------|-------------|
| PublishAsync | Method | Publishes a message asynchronously. |
| SubscribeAsync | Method | Subscribes to a queue and handles messages asynchronously. |
| StartAsync | Method | Starts the message broker asynchronously. |
| StopAsync | Method | Stops the message broker asynchronously. |

**Namespace:** `AIDevOpsCompany.Core.Interfaces`

---

## IProjectRepository

| Member | Type | Description |
|--------|------|-------------|
| GetByIdAsync | Method | Gets a project by its unique identifier asynchronously. Returns the project if found; otherwise, null. |
| GetAllAsync | Method | Gets all projects asynchronously. Returns a list of all projects. |
| CreateAsync | Method | Creates a new project asynchronously. |
| UpdateAsync | Method | Updates an existing project asynchronously. |
| DeleteAsync | Method | Deletes a project by its unique identifier asynchronously. |
| GetByStatusAsync | Method | Gets all projects by their status asynchronously. Returns a list of projects with the specified status. |

**Namespace:** `AIDevOpsCompany.Core.Interfaces`

---

## IPromptRepository

| Member | Type | Description |
|--------|------|-------------|
| GetPromptAsync | Method | Gets a specific prompt for an agent asynchronously. Returns the agent prompt if found; otherwise, null. |
| GetPromptsForAgentAsync | Method | Gets all prompts for a specific agent asynchronously. Returns a list of prompts for the specified agent. |
| SavePromptAsync | Method | Saves a new prompt asynchronously. |
| UpdatePromptAsync | Method | Updates an existing prompt asynchronously. |

**Namespace:** `AIDevOpsCompany.Core.Interfaces`

---
