using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Services;
using AIDevOpsCompany.Core.Models.Agents.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace AIDevOpsCompany.Agents.Monitoring
{
    /// <summary>
    /// Agent responsible for handling monitoring-related tasks, such as system and application monitoring.
    /// </summary>
    public class MonitoringAgent : BaseAgent
    {
        /// <summary>
        /// Gets the unique identifier for the monitoring agent.
        /// </summary>
        public override string AgentId => "monitoring-agent";

        /// <summary>
        /// Gets the role of the agent (Monitoring).
        /// </summary>
        public override string AgentRole => "Monitoring";

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringAgent"/> class.
        /// </summary>
        /// <param name="kernel">The semantic kernel for AI operations.</param>
        /// <param name="promptRepository">The prompt repository.</param>
        /// <param name="messageBroker">The message broker for communication.</param>
        /// <param name="logger">The logger instance.</param>
        public MonitoringAgent(
            Kernel kernel,
            IPromptRepository promptRepository,
            IMessageBroker messageBroker,
            ILogger<MonitoringAgent> logger)
            : base(kernel, promptRepository, messageBroker, logger)
        {
        }

        /// <summary>
        /// Processes a monitoring task, such as system or application monitoring.
        /// </summary>
        /// <param name="task">The monitoring task to process.</param>
        /// <returns>True if the task was processed successfully; otherwise, false.</returns>
        public override async Task<bool> ProcessTaskAsync(AgentTask task)
        {
            _logger.LogInformation("Processing monitoring task: {TaskType}", task.TaskType);
            try
            {
                var result = await ExecuteTaskAsync(task);
                return result.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing monitoring task");
                return false;
            }
        }

        /// <summary>
        /// Executa uma tarefa de monitoramento e retorna o resultado detalhado.
        /// </summary>
        /// <param name="task">A tarefa de monitoramento a ser executada.</param>
        /// <returns>O resultado detalhado da tarefa executada.</returns>
        public async Task<AgentTaskResult> ExecuteTaskAsync(AgentTask task)
        {
            try
            {
                _logger.LogInformation($"MonitoringAgent executando task: {task.TaskType}");
                switch (task.TaskType)
                {
                    case TaskType.MonitorDeployment:
                        return await MonitorSystemAsync(task);
                    case TaskType.BuildApplication:
                        return await MonitorApplicationAsync(task);
                    case TaskType.ManageConfiguration:
                        return await ConfigureAlertsAsync(task);
                    case TaskType.GenerateReport:
                        return await GenerateReportAsync(task);
                    case TaskType.AnalyzeComplexity:
                        return await AnalyzePerformanceAsync(task);
                    default:
                        throw new NotSupportedException($"Task type {task.TaskType} not supported by MonitoringAgent");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao executar task no MonitoringAgent");
                return new AgentTaskResult { Success = false, Message = ex.Message, Data = new Dictionary<string, object>() };
            }
        }

        /// <summary>
        /// Monitora os sistemas baseado na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição do sistema a ser monitorado.</param>
        /// <returns>O resultado do monitoramento do sistema.</returns>
        private async Task<AgentTaskResult> MonitorSystemAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "monitor_system");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var monitoringContent = await ExecutePromptAsync("monitor_system", variables);
            var monitoringResult = JsonSerializer.Deserialize<object>(monitoringContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Sistema monitorado com sucesso.",
                Data = new Dictionary<string, object> { { "SystemMonitoring", monitoringResult } }
            };
        }

        /// <summary>
        /// Monitora aplicações baseado na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição da aplicação a ser monitorada.</param>
        /// <returns>O resultado do monitoramento da aplicação.</returns>
        private async Task<AgentTaskResult> MonitorApplicationAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "monitor_application");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var appMonitoringContent = await ExecutePromptAsync("monitor_application", variables);
            var appMonitoringResult = JsonSerializer.Deserialize<object>(appMonitoringContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Aplicação monitorada com sucesso.",
                Data = new Dictionary<string, object> { { "ApplicationMonitoring", appMonitoringResult } }
            };
        }

        /// <summary>
        /// Configura alertas baseado na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição dos alertas a serem configurados.</param>
        /// <returns>O resultado da configuração dos alertas.</returns>
        private async Task<AgentTaskResult> ConfigureAlertsAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "configure_alerts");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var alertsContent = await ExecutePromptAsync("configure_alerts", variables);
            var alertsResult = JsonSerializer.Deserialize<object>(alertsContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Alertas configurados com sucesso.",
                Data = new Dictionary<string, object> { { "AlertsConfiguration", alertsResult } }
            };
        }

        /// <summary>
        /// Gera relatórios baseado na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição dos relatórios a serem gerados.</param>
        /// <returns>O resultado da geração de relatórios.</returns>
        private async Task<AgentTaskResult> GenerateReportAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "generate_report");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var reportContent = await ExecutePromptAsync("generate_report", variables);
            var reportResult = JsonSerializer.Deserialize<object>(reportContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Relatório gerado com sucesso.",
                Data = new Dictionary<string, object> { { "Report", reportResult } }
            };
        }

        /// <summary>
        /// Analisa performance baseado na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição da análise de performance.</param>
        /// <returns>O resultado da análise de performance.</returns>
        private async Task<AgentTaskResult> AnalyzePerformanceAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "analyze_performance");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var performanceContent = await ExecutePromptAsync("analyze_performance", variables);
            var performanceResult = JsonSerializer.Deserialize<object>(performanceContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Performance analisada com sucesso.",
                Data = new Dictionary<string, object> { { "PerformanceAnalysis", performanceResult } }
            };
        }
    }
}

