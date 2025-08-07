using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Services;
using AIDevOpsCompany.Core.Models.Agents.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using System.Text.Json;

namespace AIDevOpsCompany.Agents.HumanResources
{
    /// <summary>
    /// Agent responsible for handling human resources tasks such as onboarding, performance evaluation, training, wellbeing, and dispute management.
    /// </summary>
    public class HumanResourcesAgent : BaseAgent
    {
        /// <summary>
        /// Gets the unique identifier for the human resources agent.
        /// </summary>
        public override string AgentId => "hr-agent";

        /// <summary>
        /// Gets the role of the agent (HumanResources).
        /// </summary>
        public override string AgentRole => "HumanResources";

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanResourcesAgent"/> class.
        /// </summary>
        /// <param name="kernel">The semantic kernel for AI operations.</param>
        /// <param name="promptRepository">The prompt repository.</param>
        /// <param name="messageBroker">The message broker for communication.</param>
        /// <param name="logger">The logger instance.</param>
        public HumanResourcesAgent(
            Kernel kernel,
            IPromptRepository promptRepository,
            IMessageBroker messageBroker,
            ILogger<HumanResourcesAgent> logger)
            : base(kernel, promptRepository, messageBroker, logger)
        {
        }

        /// <summary>
        /// Processes a human resources task, such as onboarding, performance evaluation, or training.
        /// </summary>
        /// <param name="task">The HR task to process.</param>
        /// <returns>True if the task was processed successfully; otherwise, false.</returns>
        public override async Task<bool> ProcessTaskAsync(AgentTask task)
        {
            var result = await ExecuteTaskAsync(task);
            return result.Success;
        }

        /// <summary>
        /// Executes a human resources task and returns the result.
        /// </summary>
        /// <param name="task">The HR task to execute.</param>
        /// <returns>The result of the task execution.</returns>
        public async Task<AgentTaskResult> ExecuteTaskAsync(AgentTask task)
        {
            try
            {
                _logger.LogInformation($"HumanResourcesAgent executando task: {task.TaskType}");
                switch (task.TaskType)
                {
                    case TaskType.OnboardAgent:
                        return await OnboardAgentAsync(task);
                    case TaskType.EvaluatePerformance:
                        return await EvaluatePerformanceAsync(task);
                    case TaskType.ProvideTraining:
                        return await ProvideTrainingAsync(task);
                    case TaskType.ManageAgentWellbeing:
                        return await ManageAgentWellbeingAsync(task);
                    case TaskType.HandleDisputes:
                        return await HandleDisputesAsync(task);
                    default:
                        throw new NotSupportedException($"Task type {task.TaskType} not supported by HumanResourcesAgent");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao executar task no HumanResourcesAgent");
                return new AgentTaskResult { Success = false, Message = ex.Message, Data = new Dictionary<string, object>() };
            }
        }

        private async Task<AgentTaskResult> OnboardAgentAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "hr_onboard_agent");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var onboardContent = await ExecutePromptAsync("hr_onboard_agent", variables);
            var onboardingResult = JsonSerializer.Deserialize<object>(onboardContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Agent onboarded.",
                Data = new Dictionary<string, object> { { "OnboardingResult", onboardingResult } }
            };
        }

        private async Task<AgentTaskResult> EvaluatePerformanceAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "hr_evaluate_performance");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var evalContent = await ExecutePromptAsync("hr_evaluate_performance", variables);
            var evaluationResult = JsonSerializer.Deserialize<object>(evalContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Performance evaluation completed.",
                Data = new Dictionary<string, object> { { "EvaluationResult", evaluationResult } }
            };
        }

        private async Task<AgentTaskResult> ProvideTrainingAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "hr_provide_training");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var trainingContent = await ExecutePromptAsync("hr_provide_training", variables);
            var trainingResult = JsonSerializer.Deserialize<object>(trainingContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Training provided.",
                Data = new Dictionary<string, object> { { "TrainingResult", trainingResult } }
            };
        }

        private async Task<AgentTaskResult> ManageAgentWellbeingAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "hr_manage_agent_wellbeing");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var wellbeingContent = await ExecutePromptAsync("hr_manage_agent_wellbeing", variables);
            var wellbeingResult = JsonSerializer.Deserialize<object>(wellbeingContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Agent wellbeing managed.",
                Data = new Dictionary<string, object> { { "WellbeingResult", wellbeingResult } }
            };
        }

        private async Task<AgentTaskResult> HandleDisputesAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "hr_handle_disputes");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var disputeContent = await ExecutePromptAsync("hr_handle_disputes", variables);
            var disputeResult = JsonSerializer.Deserialize<object>(disputeContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Dispute handled.",
                Data = new Dictionary<string, object> { { "DisputeResult", disputeResult } }
            };
        }
    }
}

