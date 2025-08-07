using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Services;
using AIDevOpsCompany.Core.Models.Agents.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using System.Text.Json;

namespace AIDevOpsCompany.Agents.Security
{
    /// <summary>
    /// Represents the Security Agent responsible for handling security-related tasks.
    /// </summary>
    public class SecurityAgent : BaseAgent
    {
        /// <summary>
        /// Gets the unique identifier for the Security Agent.
        /// </summary>
        public override string AgentId => "security-agent";
        /// <summary>
        /// Gets the role of the agent, which is Security.
        /// </summary>
        public override string AgentRole => "Security";

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAgent"/> class.
        /// </summary>
        /// <param name="kernel">The semantic kernel for AI operations.</param>
        /// <param name="promptRepository">The prompt repository for retrieving prompts.</param>
        /// <param name="messageBroker">The message broker for inter-agent communication.</param>
        /// <param name="logger">The logger instance for logging operations.</param>
        public SecurityAgent(
            Kernel kernel,
            IPromptRepository promptRepository,
            IMessageBroker messageBroker,
            ILogger<SecurityAgent> logger)
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
                _logger.LogInformation($"SecurityAgent executando task: {task.TaskType}");
                switch (task.TaskType)
                {
                    case TaskType.SecurityTest:
                        return await AnalyzeVulnerabilitiesAsync(task);
                    case TaskType.PerformSecurityAudit:
                        return await PerformAuditAsync(task);
                    case TaskType.ManageCompliance:
                        return await ManageComplianceAsync(task);
                    case TaskType.RespondToIncident:
                        return await RespondToIncidentAsync(task);
                    case TaskType.ImplementSecurityMeasures:
                        return await ImplementMeasuresAsync(task);
                    default:
                        throw new NotSupportedException($"Task type {task.TaskType} not supported by SecurityAgent");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao executar task no SecurityAgent");
                return new AgentTaskResult { Success = false, Message = ex.Message, Data = new Dictionary<string, object>() };
            }
        }

        /// <summary>
        /// Analyzes vulnerabilities based on the provided agent task.
        /// </summary>
        /// <param name="task">The agent task containing security test description.</param>
        /// <returns>The result of the vulnerability analysis.</returns>
        private async Task<AgentTaskResult> AnalyzeVulnerabilitiesAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "security_analyze_vulnerabilities");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var vulnContent = await ExecutePromptAsync("security_analyze_vulnerabilities", variables);
            var vulnReport = JsonSerializer.Deserialize<object>(vulnContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Vulnerability analysis completed.",
                Data = new Dictionary<string, object> { { "VulnerabilityReport", vulnReport } }
            };
        }

        /// <summary>
        /// Performs a security audit based on the provided agent task.
        /// </summary>
        /// <param name="task">The agent task containing audit description.</param>
        /// <returns>The result of the security audit.</returns>
        private async Task<AgentTaskResult> PerformAuditAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "security_perform_audit");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var auditContent = await ExecutePromptAsync("security_perform_audit", variables);
            var auditReport = JsonSerializer.Deserialize<object>(auditContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Security audit completed.",
                Data = new Dictionary<string, object> { { "AuditReport", auditReport } }
            };
        }

        /// <summary>
        /// Manages compliance based on the provided agent task.
        /// </summary>
        /// <param name="task">The agent task containing compliance description.</param>
        /// <returns>The result of the compliance management.</returns>
        private async Task<AgentTaskResult> ManageComplianceAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "security_manage_compliance");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var complianceContent = await ExecutePromptAsync("security_manage_compliance", variables);
            var complianceReport = JsonSerializer.Deserialize<object>(complianceContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Compliance management completed.",
                Data = new Dictionary<string, object> { { "ComplianceReport", complianceReport } }
            };
        }

        /// <summary>
        /// Responds to a security incident based on the provided agent task.
        /// </summary>
        /// <param name="task">The agent task containing incident description.</param>
        /// <returns>The result of the incident response.</returns>
        private async Task<AgentTaskResult> RespondToIncidentAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "security_respond_to_incident");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var incidentContent = await ExecutePromptAsync("security_respond_to_incident", variables);
            var incidentResult = JsonSerializer.Deserialize<object>(incidentContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Incident response completed.",
                Data = new Dictionary<string, object> { { "IncidentResult", incidentResult } }
            };
        }

        /// <summary>
        /// Implements security measures based on the provided agent task.
        /// </summary>
        /// <param name="task">The agent task containing measures description.</param>
        /// <returns>The result of the implemented security measures.</returns>
        private async Task<AgentTaskResult> ImplementMeasuresAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "security_implement_measures");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var measuresContent = await ExecutePromptAsync("security_implement_measures", variables);
            var measuresResult = JsonSerializer.Deserialize<object>(measuresContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Security measures implemented.",
                Data = new Dictionary<string, object> { { "MeasuresResult", measuresResult } }
            };
        }
    }
}

