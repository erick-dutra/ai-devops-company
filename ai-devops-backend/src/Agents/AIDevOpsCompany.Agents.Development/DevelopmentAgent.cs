using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Services;
using AIDevOpsCompany.Core.Models.Agents.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AIDevOpsCompany.Agents.Development
{
    /// <summary>
    /// Agent responsible for handling development-related tasks such as code generation, review, refactoring, and testing.
    /// </summary>
    public class DevelopmentAgent : BaseAgent
    {
        /// <summary>
        /// Gets the unique identifier for the development agent.
        /// </summary>
        public override string AgentId => "development-agent";

        /// <summary>
        /// Gets the role of the agent (Development).
        /// </summary>
        public override string AgentRole => "Development";

        /// <summary>
        /// Initializes a new instance of the <see cref="DevelopmentAgent"/> class.
        /// </summary>
        /// <param name="kernel">The semantic kernel for AI operations.</param>
        /// <param name="promptRepository">The prompt repository.</param>
        /// <param name="messageBroker">The message broker for communication.</param>
        /// <param name="logger">The logger instance.</param>
        public DevelopmentAgent(
            Kernel kernel,
            IPromptRepository promptRepository,
            IMessageBroker messageBroker,
            ILogger<DevelopmentAgent> logger)
            : base(kernel, promptRepository, messageBroker, logger)
        {
        }

        /// <summary>
        /// Processes a development task, such as code generation, review, or optimization.
        /// </summary>
        /// <param name="task">The development task to process.</param>
        /// <returns>True if the task was processed successfully; otherwise, false.</returns>
        public override async Task<bool> ProcessTaskAsync(AgentTask task)
        {
            _logger.LogInformation("Processing development task: {TaskType}", task.TaskType);
            try
            {
                var result = await ExecuteTaskAsync(task);
                return result.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing development task");
                return false;
            }
        }

        /// <summary>
        /// Executa uma tarefa de desenvolvimento e retorna o resultado detalhado.
        /// </summary>
        /// <param name="task">A tarefa de desenvolvimento a ser executada.</param>
        /// <returns>O resultado detalhado da tarefa executada.</returns>
        public async Task<AgentTaskResult> ExecuteTaskAsync(AgentTask task)
        {
            try
            {
                _logger.LogInformation($"DevelopmentAgent executando task: {task.TaskType}");
                switch (task.TaskType)
                {
                    case TaskType.GenerateCode:
                        return await GenerateCodeAsync(task);
                    case TaskType.ReviewCode:
                        return await ReviewCodeAsync(task);
                    case TaskType.RefactorCode:
                        return await RefactorCodeAsync(task);
                    case TaskType.GenerateTests:
                        return await GenerateTestsAsync(task);
                    case TaskType.AnalyzeComplexity:
                        return await AnalyzeComplexityAsync(task);
                    case TaskType.OptimizePerformance:
                        return await OptimizePerformanceAsync(task);
                    default:
                        throw new NotSupportedException($"Task type {task.TaskType} not supported by DevelopmentAgent");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao executar task no DevelopmentAgent");
                return new AgentTaskResult { Success = false, Message = ex.Message, Data = new Dictionary<string, object>() };
            }
        }

        /// <summary>
        /// Gera código com base na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo a descrição do código a ser gerado.</param>
        /// <returns>O resultado da geração de código.</returns>
        private async Task<AgentTaskResult> GenerateCodeAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "generate_code");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description },
                { "language", "csharp" },
                { "framework", "net7.0" }
            };
            var codeContent = await ExecutePromptAsync("generate_code", variables);
            var codeResult = JsonSerializer.Deserialize<object>(codeContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Código gerado com sucesso.",
                Data = new Dictionary<string, object> { { "GeneratedCode", codeResult } }
            };
        }

        /// <summary>
        /// Revisa o código fornecido na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo o código a ser revisado.</param>
        /// <returns>O resultado da revisão do código.</returns>
        private async Task<AgentTaskResult> ReviewCodeAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "review_code");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description },
                { "code", task.Description } // Assumimos que o código está na descrição da tarefa
            };
            var reviewContent = await ExecutePromptAsync("review_code", variables);
            var reviewResult = JsonSerializer.Deserialize<object>(reviewContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Revisão de código concluída.",
                Data = new Dictionary<string, object> { { "CodeReview", reviewResult } }
            };
        }

        /// <summary>
        /// Refatora o código fornecido na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo o código a ser refatorado.</param>
        /// <returns>O resultado da refatoração do código.</returns>
        private async Task<AgentTaskResult> RefactorCodeAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "refactor_code");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description },
                { "code", task.Description } // Assumimos que o código está na descrição da tarefa
            };
            var refactoredContent = await ExecutePromptAsync("refactor_code", variables);
            var refactoredResult = JsonSerializer.Deserialize<object>(refactoredContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Código refatorado com sucesso.",
                Data = new Dictionary<string, object> { { "RefactoredCode", refactoredResult } }
            };
        }

        /// <summary>
        /// Gera testes para o código fornecido na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo o código para o qual os testes serão gerados.</param>
        /// <returns>O resultado da geração de testes.</returns>
        private async Task<AgentTaskResult> GenerateTestsAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "generate_tests");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description },
                { "code", task.Description }, // Assumimos que o código está na descrição da tarefa
                { "testFramework", "xunit" }
            };
            var testsContent = await ExecutePromptAsync("generate_tests", variables);
            var testsResult = JsonSerializer.Deserialize<object>(testsContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Testes gerados com sucesso.",
                Data = new Dictionary<string, object> { { "GeneratedTests", testsResult } }
            };
        }

        /// <summary>
        /// Analisa a complexidade do código fornecido na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo o código a ser analisado.</param>
        /// <returns>O resultado da análise de complexidade.</returns>
        private async Task<AgentTaskResult> AnalyzeComplexityAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "analyze_complexity");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description },
                { "code", task.Description } // Assumimos que o código está na descrição da tarefa
            };
            var analysisContent = await ExecutePromptAsync("analyze_complexity", variables);
            var analysisResult = JsonSerializer.Deserialize<object>(analysisContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Análise de complexidade concluída.",
                Data = new Dictionary<string, object> { { "ComplexityAnalysis", analysisResult } }
            };
        }

        /// <summary>
        /// Otimiza o desempenho do código fornecido na descrição da tarefa.
        /// </summary>
        /// <param name="task">A tarefa contendo o código a ser otimizado.</param>
        /// <returns>O resultado da otimização de desempenho.</returns>
        private async Task<AgentTaskResult> OptimizePerformanceAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "optimize_performance");
            var variables = new Dictionary<string, object> { 
                { "description", task.Description },
                { "code", task.Description } // Assumimos que o código está na descrição da tarefa
            };
            var optimizedContent = await ExecutePromptAsync("optimize_performance", variables);
            var optimizedResult = JsonSerializer.Deserialize<object>(optimizedContent) ?? new object();
            return new AgentTaskResult
            {
                Success = true,
                Message = "Otimização de desempenho concluída.",
                Data = new Dictionary<string, object> { { "OptimizedCode", optimizedResult } }
            };
        }
    }
}

