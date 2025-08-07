# AI DevOps Infrastructure Documentation

This document provides structured, tabular documentation for all interfaces, classes, and other artifacts in the Infrastructure layer of the AI DevOps backend project.

---

## ILlamaClient Interface

| Member | Type | Description |
|--------|------|-------------|
| `GenerateResponseAsync` | `Task<string>` | Generates a response from the Llama model based on the provided prompt and model name. |
| `GenerateCodeAsync` | `Task<string>` | Generates code in the specified language using the Llama model based on the provided prompt. |
| `AnalyzeRequirementsAsync` | `Task<string>` | Analyzes software requirements and provides insights or suggestions using the Llama model. |
| `ReviewCodeAsync` | `Task<string>` | Reviews the provided code in the specified language and returns feedback or suggestions. |
| `GenerateTestsAsync` | `Task<string>` | Generates unit or integration tests for the provided code in the specified language. |
| `AnalyzeSecurityAsync` | `Task<string>` | Analyzes the provided code for security vulnerabilities and provides recommendations. |
| `IsHealthyAsync` | `Task<bool>` | Checks the health status of the Llama service or client. |
| `GetAvailableModelsAsync` | `Task<List<string>>` | Retrieves a list of available Llama models that can be used for inference. |

---

## LlamaClient Class

| Member | Type | Description |
|--------|------|-------------|
| `_httpClient` | `HttpClient` | The HTTP client used for making requests to the Llama API. |
| `_logger` | `ILogger<LlamaClient>` | Logger for logging errors and information. |
| `_settings` | `LlamaSettings` | Configuration settings for the Llama client. |
| `LlamaClient(HttpClient, IOptions<LlamaSettings>, ILogger<LlamaClient>)` | Constructor | Initializes a new instance of the LlamaClient class. |
| `GenerateResponseAsync` | `Task<string>` | Generates a response from the Llama model based on the provided prompt and model name. |
| `GenerateCodeAsync` | `Task<string>` | Generates code in the specified language using the Llama model based on the provided prompt. |
| `AnalyzeRequirementsAsync` | `Task<string>` | Analyzes software requirements and provides insights or suggestions using the Llama model. |
| `ReviewCodeAsync` | `Task<string>` | Reviews the provided code in the specified language and returns feedback or suggestions. |
| `GenerateTestsAsync` | `Task<string>` | Generates unit or integration tests for the provided code in the specified language. |
| `AnalyzeSecurityAsync` | `Task<string>` | Analyzes the provided code for security vulnerabilities and provides recommendations. |
| `IsHealthyAsync` | `Task<bool>` | Checks the health status of the Llama service or client. |
| `GetAvailableModelsAsync` | `Task<List<string>>` | Retrieves a list of available Llama models that can be used for inference. |
| `SendRequestAsync<TRequest, TResponse>` | `Task<TResponse?>` | Sends a POST request to the Llama API and deserializes the response. |

---

## LlamaSettings Class

| Member | Type | Description |
|--------|------|-------------|
| `BaseUrl` | `string` | The base URL of the Llama API service. |
| `Timeout` | `int` | Timeout in seconds for HTTP requests. |
| `DefaultModel` | `string` | The default Llama model to use for inference. |

---

## LlamaGenerateRequest Class

| Member | Type | Description |
|--------|------|-------------|
| `Model` | `string` | The name of the Llama model to use. |
| `Prompt` | `string` | The prompt to send to the Llama model. |
| `Stream` | `bool` | Whether to stream the response. |
| `Options` | `LlamaOptions?` | Additional options for the Llama model. |

---

## LlamaOptions Class

| Member | Type | Description |
|--------|------|-------------|
| `Temperature` | `double` | Sampling temperature for response generation. |
| `TopP` | `double` | Nucleus sampling probability. |
| `TopK` | `int` | Top-K sampling parameter. |
| `NumCtx` | `int` | Number of context tokens. |

---

## LlamaGenerateResponse Class

| Member | Type | Description |
|--------|------|-------------|
| `Model` | `string` | The name of the Llama model used. |
| `Response` | `string` | The generated response from the model. |
| `Done` | `bool` | Indicates if the response is complete. |
| `CreatedAt` | `DateTime` | The creation timestamp of the response. |

---

## LlamaModelsResponse Class

| Member | Type | Description |
|--------|------|-------------|
| `Models` | `List<LlamaModel>?` | List of available Llama models. |

---

## LlamaModel Class

| Member | Type | Description |
|--------|------|-------------|
| `Name` | `string` | The name of the Llama model. |
| `ModifiedAt` | `DateTime` | The last modified timestamp of the model. |
| `Size` | `long` | The size of the model in bytes. |

---

## ServiceCollectionExtensions Class

| Member | Type | Description |
|--------|------|-------------|
| `AddLlamaClient` | `IServiceCollection` | Extension method to register LlamaClient, IAIService, and related settings in the service collection. |

---

## ServiceCollectionExtensions Class (Messaging)

| Member | Type | Description |
|--------|------|-------------|
| `AddRabbitMQMessaging` | `IServiceCollection` | Extension method to register RabbitMQ messaging, message broker, handlers, and background services in the service collection. |

---

## MongoPromptRepository Class

| Member | Type | Description |
|--------|------|-------------|
| `_prompts` | `IMongoCollection<AgentPrompt>` | MongoDB collection for agent prompts. |
| `MongoPromptRepository` | Constructor | Initializes a new instance using MongoDB settings. |
| `GetPromptAsync` | `Task<AgentPrompt?>` | Retrieves a prompt for a specific agent role and prompt name. |
| `GetPromptsForAgentAsync` | `Task<List<AgentPrompt>>` | Retrieves all prompts for a specific agent role. |
| `SavePromptAsync` | `Task` | Saves a new agent prompt to the collection. |
| `UpdatePromptAsync` | `Task` | Updates an existing agent prompt in the collection. |

---

## MongoDbSettings Class

| Member | Type | Description |
|--------|------|-------------|
| `ConnectionString` | `string` | The MongoDB connection string. |
| `DatabaseName` | `string` | The name of the MongoDB database. |

---

## MongoProjectRepository Class

| Member | Type | Description |
|--------|------|-------------|
| `_projects` | `IMongoCollection<Project>` | MongoDB collection for projects. |
| `MongoProjectRepository` | Constructor | Initializes a new instance using MongoDB settings. |
| `GetByIdAsync` | `Task<Project?>` | Retrieves a project by its ID. |
| `GetAllAsync` | `Task<List<Project>>` | Retrieves all projects. |
| `CreateAsync` | `Task` | Inserts a new project into the collection. |
| `UpdateAsync` | `Task` | Updates an existing project in the collection. |
| `DeleteAsync` | `Task` | Deletes a project by its ID. |
| `GetByStatusAsync` | `Task<List<Project>>` | Retrieves projects by their status. |

---

## MongoDevelopmentTaskRepository Class

| Member | Type | Description |
|--------|------|-------------|
| `_developmentTasks` | `IMongoCollection<DevelopmentTask>` | MongoDB collection for development tasks. |
| `MongoDevelopmentTaskRepository` | Constructor | Initializes a new instance using MongoDB settings. |
| `GetByIdAsync` | `Task<DevelopmentTask?>` | Retrieves a development task by its ID. |
| `GetAllAsync` | `Task<List<DevelopmentTask>>` | Retrieves all development tasks. |
| `CreateAsync` | `Task` | Inserts a new development task into the collection. |
| `UpdateAsync` | `Task` | Updates an existing development task in the collection. |
| `DeleteAsync` | `Task` | Deletes a development task by its ID. |
| `GetByProjectIdAsync` | `Task<List<DevelopmentTask>>` | Retrieves development tasks by project ID. |
| `GetByStatusAsync` | `Task<List<DevelopmentTask>>` | Retrieves development tasks by their status. |

---

## IAgentMessageHandler Interface

| Member | Type | Description |
|--------|------|-------------|
| `HandleTaskMessageAsync` | `Task` | Handles a task message sent to an agent. |
| `HandleEventMessageAsync` | `Task` | Handles an event message sent to or from an agent. |
| `HandleNotificationMessageAsync` | `Task` | Handles a notification message sent to agents. |

---

## AgentMessageHandler Class

| Member | Type | Description |
|--------|------|-------------|
| `_logger` | `ILogger<AgentMessageHandler>` | Logger for logging agent message handling operations. |
| `_agents` | `Dictionary<string, IAgent>` | Dictionary of agents indexed by their AgentId. |
| `AgentMessageHandler` | Constructor | Initializes a new instance using the logger and collection of agents. |
| `HandleTaskMessageAsync` | `Task` | Handles a task message sent to an agent. |
| `HandleEventMessageAsync` | `Task` | Handles an event message sent to or from an agent. |
| `HandleNotificationMessageAsync` | `Task` | Handles a notification message sent to agents. |
| `HandleTaskCompletedEvent` | `Task` | Handles a task completed event message. |
| `HandleTaskFailedEvent` | `Task` | Handles a task failed event message. |
| `HandleStatusUpdateEvent` | `Task` | Handles a status update event message. |
| `HandleErrorReportEvent` | `Task` | Handles an error report event message. |

---

## MessageProcessingService Class

| Member | Type | Description |
|--------|------|-------------|
| `_logger` | `ILogger<MessageProcessingService>` | Logger for logging service operations. |
| `_serviceProvider` | `IServiceProvider` | Service provider for resolving scoped dependencies. |
| `MessageProcessingService` | Constructor | Initializes a new instance using the logger and service provider. |
| `ExecuteAsync` | `Task` | Executes the background service, subscribing to agent queues and processing messages. |
| `SubscribeToAgentQueues` | `Task` | Subscribes to agent task, event, and notification queues and processes incoming messages. |
| `StopAsync` | `Task` | Stops the background service. |

---

## RabbitMQMessageBroker Class

| Member | Type | Description |
|--------|------|-------------|
| `_connection` | `IConnection` | The RabbitMQ connection instance. |
| `_channel` | `IModel` | The RabbitMQ channel for communication. |
| `_logger` | `ILogger<RabbitMQMessageBroker>` | Logger for logging broker operations. |
| `_settings` | `RabbitMQSettings` | RabbitMQ configuration settings. |
| `_disposed` | `bool` | Indicates whether the broker has been disposed. |
| `RabbitMQMessageBroker` | Constructor | Initializes a new instance using RabbitMQ settings and logger. |
| `PublishAsync<T>` | `Task` | Publishes a message to the appropriate RabbitMQ exchange. |
| `SubscribeAsync<T>` | `Task` | Subscribes to a RabbitMQ queue and processes messages using the provided handler. |
| `StartAsync` | `Task` | Starts the RabbitMQ message broker. |
| `StopAsync` | `Task` | Stops the RabbitMQ message broker and disposes resources. |
| `DeclareExchanges` | `void` | Declares the necessary RabbitMQ exchanges for agent messaging. |
| `GetExchangeAndRoutingKey` | `(string, string)` | Determines the exchange and routing key for a given message type. |
| `Dispose` | `void` | Disposes the RabbitMQ connection and channel resources. |

---

## RabbitMQSettings Class

| Member | Type | Description |
|--------|------|-------------|
| `HostName` | `string` | The RabbitMQ host name. |
| `Port` | `int` | The RabbitMQ port number. |
| `UserName` | `string` | The RabbitMQ user name. |
| `Password` | `string` | The RabbitMQ password. |
| `VirtualHost` | `string` | The RabbitMQ virtual host. |
| `AutomaticRecoveryEnabled` | `bool` | Whether automatic recovery is enabled for the connection. |
| `NetworkRecoveryInterval` | `int` | The interval (in seconds) for network recovery attempts. |
| `RequestedHeartbeat` | `int` | The requested heartbeat interval (in seconds). |

---

*Last updated: 2025-06-19*
