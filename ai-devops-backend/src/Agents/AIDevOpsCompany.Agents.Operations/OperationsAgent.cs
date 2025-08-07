using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Services;
using AIDevOpsCompany.Core.Models.Agents.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace AIDevOpsCompany.Agents.Operations
{
    /// <summary>
    /// Agent responsible for handling operations-related tasks such as build, deployment, CI/CD, and configuration management.
    /// </summary>
    public class OperationsAgent : BaseAgent
    {
        /// <summary>
        /// Gets the unique identifier for the operations agent.
        /// </summary>
        public override string AgentId => "operations-agent";

        /// <summary>
        /// Gets the role of the agent (Operations).
        /// </summary>
        public override string AgentRole => "Operations";

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsAgent"/> class.
        /// </summary>
        /// <param name="kernel">The semantic kernel for AI operations.</param>
        /// <param name="promptRepository">The prompt repository.</param>
        /// <param name="messageBroker">The message broker for communication.</param>
        /// <param name="logger">The logger instance.</param>
        public OperationsAgent(
            Kernel kernel,
            IPromptRepository promptRepository,
            IMessageBroker messageBroker,
            ILogger<OperationsAgent> logger)
            : base(kernel, promptRepository, messageBroker, logger)
        {
        }

        /// <summary>
        /// Processes an operations task, such as build, deployment, or CI/CD pipeline execution.
        /// </summary>
        /// <param name="task">The operations task to process.</param>
        /// <returns>True if the task was processed successfully; otherwise, false.</returns>
        public override async Task<bool> ProcessTaskAsync(AgentTask task)
        {
            _logger.LogInformation("Processing operations task: {TaskType}", task.TaskType);
            try
            {
                var result = await ExecuteTaskAsync(task);
                return result.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing operations task");
                return false;
            }
        }

        /// <summary>
        /// Executa uma tarefa de operações e retorna o resultado detalhado.
        /// </summary>
        /// <param name="task">A tarefa de operações a ser executada.</param>
        /// <returns>O resultado detalhado da tarefa executada.</returns>
        public async Task<AgentTaskResult> ExecuteTaskAsync(AgentTask task)
        {
            try
            {
                _logger.LogInformation($"OperationsAgent executando task: {task.TaskType}");
                switch (task.TaskType)
                {
                    case TaskType.BuildApplication:
                        return await BuildApplicationAsync(task);
                    case TaskType.DeployApplication:
                        return await DeployApplicationAsync(task);
                    case TaskType.RunCICDPipeline:
                        return await RunCICDPipelineAsync(task);
                    case TaskType.AutomateTests:
                        return await AutomateTestsAsync(task);
                    case TaskType.ManageConfiguration:
                        return await ManageConfigurationAsync(task);
                    case TaskType.MonitorDeployment:
                        return await MonitorDeploymentAsync(task);
                    default:
                        throw new NotSupportedException($"Task type {task.TaskType} not supported by OperationsAgent");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao executar task no OperationsAgent");
                return new AgentTaskResult { Success = false, Message = ex.Message, Data = new Dictionary<string, object>() };
            }
        }

        /// <summary>
        /// Constrói uma aplicação com base na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição da aplicação a ser construída.</param>
        /// <returns>O resultado da construção da aplicação.</returns>
        private async Task<AgentTaskResult> BuildApplicationAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "build_application");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var buildContent = await ExecutePromptAsync("build_application", variables);
            var buildResult = JsonSerializer.Deserialize<object>(buildContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Aplicação construída com sucesso.",
                Data = new Dictionary<string, object> { { "BuildResult", buildResult } }
            };
        }

        /// <summary>
        /// Realiza o deploy de uma aplicação com base na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição da aplicação a ser deployada.</param>
        /// <returns>O resultado do deploy da aplicação.</returns>
        private async Task<AgentTaskResult> DeployApplicationAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "deploy_application");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var deployContent = await ExecutePromptAsync("deploy_application", variables);
            var deployResult = JsonSerializer.Deserialize<object>(deployContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Aplicação deployada com sucesso.",
                Data = new Dictionary<string, object> { { "DeployResult", deployResult } }
            };
        }

        /// <summary>
        /// Executa pipeline CI/CD com base na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição do pipeline a ser executado.</param>
        /// <returns>O resultado da execução do pipeline.</returns>
        private async Task<AgentTaskResult> RunCICDPipelineAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "run_cicd_pipeline");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var pipelineContent = await ExecutePromptAsync("run_cicd_pipeline", variables);
            var pipelineResult = JsonSerializer.Deserialize<object>(pipelineContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Pipeline CI/CD executado com sucesso.",
                Data = new Dictionary<string, object> { { "PipelineResult", pipelineResult } }
            };
        }

        /// <summary>
        /// Automatiza testes com base na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição dos testes a serem automatizados.</param>
        /// <returns>O resultado da automação de testes.</returns>
        private async Task<AgentTaskResult> AutomateTestsAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "automate_tests");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var testsContent = await ExecutePromptAsync("automate_tests", variables);
            var testsResult = JsonSerializer.Deserialize<object>(testsContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Testes automatizados com sucesso.",
                Data = new Dictionary<string, object> { { "AutomatedTests", testsResult } }
            };
        }

        /// <summary>
        /// Gerencia configurações com base na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição das configurações a serem gerenciadas.</param>
        /// <returns>O resultado do gerenciamento de configurações.</returns>
        private async Task<AgentTaskResult> ManageConfigurationAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "manage_configuration");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var configContent = await ExecutePromptAsync("manage_configuration", variables);
            var configResult = JsonSerializer.Deserialize<object>(configContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Configurações gerenciadas com sucesso.",
                Data = new Dictionary<string, object> { { "ConfigurationManagement", configResult } }
            };
        }

        /// <summary>
        /// Monitora o deploy com base na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição do deploy a ser monitorado.</param>
        /// <returns>O resultado do monitoramento do deploy.</returns>
        private async Task<AgentTaskResult> MonitorDeploymentAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "monitor_deployment");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description }
            };
            var monitorContent = await ExecutePromptAsync("monitor_deployment", variables);
            var monitorResult = JsonSerializer.Deserialize<object>(monitorContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Deploy monitorado com sucesso.",
                Data = new Dictionary<string, object> { { "DeploymentMonitoring", monitorResult } }
            };
        }
    }
}

