using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Services;
using AIDevOpsCompany.Core.Models.Agents.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using System.Text.Json;

namespace AIDevOpsCompany.Agents.ProjectManagement
{
    /// <summary>
    /// Agent responsible for handling project management tasks such as project creation, updating, analysis, planning, progress tracking, and reporting.
    /// </summary>
    public class ProjectManagementAgent : BaseAgent
    {
        /// <summary>
        /// Gets the unique identifier for the project management agent.
        /// </summary>
        public override string AgentId => "project-management-agent";

        /// <summary>
        /// Gets the role of the agent (ProjectManagement).
        /// </summary>
        public override string AgentRole => "ProjectManagement";

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectManagementAgent"/> class.
        /// </summary>
        /// <param name="kernel">The semantic kernel for AI operations.</param>
        /// <param name="promptRepository">The prompt repository.</param>
        /// <param name="messageBroker">The message broker for communication.</param>
        /// <param name="logger">The logger instance.</param>
        public ProjectManagementAgent(
            Kernel kernel,
            IPromptRepository promptRepository,
            IMessageBroker messageBroker,
            ILogger<ProjectManagementAgent> logger)
            : base(kernel, promptRepository, messageBroker, logger)
        {
        }

        /// <summary>
        /// Processes a project management task, such as project creation, updating, or reporting.
        /// </summary>
        /// <param name="task">The project management task to process.</param>
        /// <returns>True if the task was processed successfully; otherwise, false.</returns>
        public override async Task<bool> ProcessTaskAsync(AgentTask task)
        {
            var result = await ExecuteTaskAsync(task);
            return result.Success;
        }

        /// <summary>
        /// Executes a project management task and returns the result.
        /// </summary>
        /// <param name="task">The project management task to execute.</param>
        /// <returns>The result of the task execution.</returns>
        public async Task<AgentTaskResult> ExecuteTaskAsync(AgentTask task)
        {
            try
            {
                _logger.LogInformation($"ProjectManagementAgent executando task: {task.TaskType}");
                switch (task.TaskType)
                {
                    case TaskType.CreateProject:
                        return await CreateProjectAsync(task);
                    case TaskType.UpdateProject:
                        return await UpdateProjectAsync(task);
                    case TaskType.AnalyzeProject:
                        return await AnalyzeProjectAsync(task);
                    case TaskType.GenerateProjectPlan:
                        return await GenerateProjectPlanAsync(task);
                    case TaskType.TrackProgress:
                        return await TrackProgressAsync(task);
                    case TaskType.GenerateReport:
                        return await GenerateReportAsync(task);
                    default:
                        throw new NotSupportedException($"Task type {task.TaskType} not supported by ProjectManagementAgent");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao executar task no ProjectManagementAgent");
                return new AgentTaskResult { Success = false, Message = ex.Message, Data = new Dictionary<string, object>() };
            }
        }

        /// <summary>
        /// Creates a new project based on the provided task description.
        /// </summary>
        /// <param name="task">The project creation task.</param>
        /// <returns>The result of the project creation operation.</returns>
        private async Task<AgentTaskResult> CreateProjectAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "create_project");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var projectContent = await ExecutePromptAsync("create_project", variables);
            var project = JsonSerializer.Deserialize<object>(projectContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Project created.",
                Data = new Dictionary<string, object> { { "Project", project } }
            };
        }

        /// <summary>
        /// Updates an existing project based on the provided task description.
        /// </summary>
        /// <param name="task">The project update task.</param>
        /// <returns>The result of the project update operation.</returns>
        private async Task<AgentTaskResult> UpdateProjectAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "update_project");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var updateContent = await ExecutePromptAsync("update_project", variables);
            var update = JsonSerializer.Deserialize<object>(updateContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Project updated.",
                Data = new Dictionary<string, object> { { "Update", update } }
            };
        }

        /// <summary>
        /// Analyzes a project based on the provided task description.
        /// </summary>
        /// <param name="task">The project analysis task.</param>
        /// <returns>The result of the project analysis operation.</returns>
        private async Task<AgentTaskResult> AnalyzeProjectAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "analyze_project");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var analysisContent = await ExecutePromptAsync("analyze_project", variables);
            var analysis = JsonSerializer.Deserialize<object>(analysisContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Project analyzed.",
                Data = new Dictionary<string, object> { { "Analysis", analysis } }
            };
        }

        /// <summary>
        /// Generates a project plan based on the provided task description.
        /// </summary>
        /// <param name="task">The project plan generation task.</param>
        /// <returns>The result of the project plan generation operation.</returns>
        private async Task<AgentTaskResult> GenerateProjectPlanAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "generate_project_plan");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var planContent = await ExecutePromptAsync("generate_project_plan", variables);
            var plan = JsonSerializer.Deserialize<object>(planContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Project plan generated.",
                Data = new Dictionary<string, object> { { "ProjectPlan", plan } }
            };
        }

        /// <summary>
        /// Tracks the progress of a project based on the provided task description.
        /// </summary>
        /// <param name="task">The progress tracking task.</param>
        /// <returns>The result of the progress tracking operation.</returns>
        private async Task<AgentTaskResult> TrackProgressAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "track_progress");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var progressContent = await ExecutePromptAsync("track_progress", variables);
            var progress = JsonSerializer.Deserialize<object>(progressContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Progress tracked.",
                Data = new Dictionary<string, object> { { "Progress", progress } }
            };
        }

        /// <summary>
        /// Generates a report for a project based on the provided task description.
        /// </summary>
        /// <param name="task">The report generation task.</param>
        /// <returns>The result of the report generation operation.</returns>
        private async Task<AgentTaskResult> GenerateReportAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "generate_report");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var reportContent = await ExecutePromptAsync("generate_report", variables);
            var report = JsonSerializer.Deserialize<object>(reportContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Report generated.",
                Data = new Dictionary<string, object> { { "Report", report } }
            };
        }
    }
}

