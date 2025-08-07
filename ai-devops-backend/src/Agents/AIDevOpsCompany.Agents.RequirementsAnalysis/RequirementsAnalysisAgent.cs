using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Services;
using AIDevOpsCompany.Core.Models.Agents.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using System.Text.Json;

namespace AIDevOpsCompany.Agents.RequirementsAnalysis
{
    /// <summary>
    /// Represents the Requirements Analysis Agent responsible for analyzing requirements, creating user stories, validating requirements, and generating acceptance criteria.
    /// </summary>
    public class RequirementsAnalysisAgent : BaseAgent
    {
        /// <summary>
        /// Gets the unique identifier for the Requirements Analysis Agent.
        /// </summary>
        public override string AgentId => "requirements-analysis-agent";
        /// <summary>
        /// Gets the role of the agent, which is RequirementsAnalysis.
        /// </summary>
        public override string AgentRole => "RequirementsAnalysis";

        /// <summary>
        /// Initializes a new instance of the <see cref="RequirementsAnalysisAgent"/> class.
        /// </summary>
        /// <param name="kernel">The semantic kernel for AI operations.</param>
        /// <param name="promptRepository">The prompt repository for retrieving prompts.</param>
        /// <param name="messageBroker">The message broker for inter-agent communication.</param>
        /// <param name="logger">The logger instance for logging operations.</param>
        public RequirementsAnalysisAgent(
            Kernel kernel,
            IPromptRepository promptRepository,
            IMessageBroker messageBroker,
            ILogger<RequirementsAnalysisAgent> logger)
            : base(kernel, promptRepository, messageBroker, logger)
        {
        }

        /// <summary>
        /// Processes a given agent task asynchronously.
        /// </summary>
        /// <param name="task">The agent task to process.</param>
        /// <returns>True if the task was processed successfully; otherwise, false.</returns>
        public override async Task<bool> ProcessTaskAsync(AgentTask task)
        {
            var result = await ExecuteTaskAsync(task);
            return result.Success;
        }

        /// <summary>
        /// Executes a given agent task and returns the result.
        /// </summary>
        /// <param name="task">The agent task to execute.</param>
        /// <returns>The result of the executed agent task.</returns>
        public async Task<AgentTaskResult> ExecuteTaskAsync(AgentTask task)
        {
            try
            {
                _logger.LogInformation($"RequirementsAnalysisAgent executando task: {task.TaskType}");
                switch (task.TaskType)
                {
                    case TaskType.AnalyzeRequirements:
                        return await AnalyzeRequirementsAsync(task);
                    case TaskType.CreateUserStories:
                        return await CreateUserStoriesAsync(task);
                    case TaskType.ValidateRequirements:
                        return await ValidateRequirementsAsync(task);
                    case TaskType.GenerateAcceptanceCriteria:
                        return await GenerateAcceptanceCriteriaAsync(task);
                    default:
                        throw new NotSupportedException($"Task type {task.TaskType} not supported by RequirementsAnalysisAgent");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao executar task no RequirementsAnalysisAgent");
                return new AgentTaskResult { Success = false, Message = ex.Message, Data = new Dictionary<string, object>() };
            }
        }

        /// <summary>
        /// Analyzes requirements based on the provided agent task.
        /// </summary>
        /// <param name="task">The agent task containing requirements description.</param>
        /// <returns>The result of the requirements analysis.</returns>
        private async Task<AgentTaskResult> AnalyzeRequirementsAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "requirements_analysis");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var analysisContent = await ExecutePromptAsync("requirements_analysis", variables);
            var analysis = JsonSerializer.Deserialize<object>(analysisContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Requirements analyzed successfully.",
                Data = new Dictionary<string, object> { { "Analysis", analysis } }
            };
        }

        /// <summary>
        /// Creates user stories from the provided agent task description.
        /// </summary>
        /// <param name="task">The agent task containing requirements description.</param>
        /// <returns>The result containing generated user stories.</returns>
        private async Task<AgentTaskResult> CreateUserStoriesAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "user_stories_creation");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var storiesContent = await ExecutePromptAsync("user_stories_creation", variables);
            var userStories = JsonSerializer.Deserialize<object>(storiesContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "User stories created.",
                Data = new Dictionary<string, object> { { "UserStories", userStories } }
            };
        }

        /// <summary>
        /// Validates requirements based on the provided agent task.
        /// </summary>
        /// <param name="task">The agent task containing requirements description.</param>
        /// <returns>The result of the requirements validation.</returns>
        private async Task<AgentTaskResult> ValidateRequirementsAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "requirements_validation");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var validationContent = await ExecutePromptAsync("requirements_validation", variables);
            var validation = JsonSerializer.Deserialize<object>(validationContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Requirements validation completed.",
                Data = new Dictionary<string, object> { { "Validation", validation } }
            };
        }

        /// <summary>
        /// Generates acceptance criteria from the provided agent task description.
        /// </summary>
        /// <param name="task">The agent task containing requirements description.</param>
        /// <returns>The result containing generated acceptance criteria.</returns>
        private async Task<AgentTaskResult> GenerateAcceptanceCriteriaAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "acceptance_criteria");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var criteriaContent = await ExecutePromptAsync("acceptance_criteria", variables);
            var criteria = JsonSerializer.Deserialize<object>(criteriaContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Acceptance criteria generated.",
                Data = new Dictionary<string, object> { { "AcceptanceCriteria", criteria } }
            };
        }
    }
}

