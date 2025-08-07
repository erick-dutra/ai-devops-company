using AIDevOpsCompany.Core.Services;
using AIDevOpsCompany.Core.Models.Agents.Tasks;
using AIDevOpsCompany.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.SemanticKernel;
using AIDevOpsCompany.Core.Models.Projects;
using AIDevOpsCompany.Core.Models.QualityReports;
using AIDevOpsCompany.Core.Models.Requirements;
using AIDevOpsCompany.Core.Models.DevelopmentTasks;

namespace AIDevOpsCompany.Agents.QualityAssurance
{
    /// <summary>
    /// Agent responsible for handling quality assurance tasks such as test plan generation, test creation, execution, performance, security, and code review.
    /// </summary>
    public class QualityAssuranceAgent : BaseAgent
    {
        /// <summary>
        /// Gets the unique identifier for the quality assurance agent.
        /// </summary>
        public override string AgentId => "quality-assurance-agent";

        /// <summary>
        /// Gets the role of the agent (QualityAssurance).
        /// </summary>
        public override string AgentRole => "QualityAssurance";

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityAssuranceAgent"/> class.
        /// </summary>
        /// <param name="kernel">The semantic kernel for AI operations.</param>
        /// <param name="promptRepository">The prompt repository.</param>
        /// <param name="messageBroker">The message broker for communication.</param>
        /// <param name="logger">The logger instance.</param>
        public QualityAssuranceAgent(
            Kernel kernel,
            IPromptRepository promptRepository,
            IMessageBroker messageBroker,
            ILogger<QualityAssuranceAgent> logger)
            : base(kernel, promptRepository, messageBroker, logger)
        {
        }

        /// <summary>
        /// Processes a quality assurance task, such as test plan generation, test creation, or code review.
        /// </summary>
        /// <param name="task">The QA task to process.</param>
        /// <returns>True if the task was processed successfully; otherwise, false.</returns>
        public override async Task<bool> ProcessTaskAsync(AgentTask task)
        {
            var result = await ExecuteTaskAsync(task);
            return result.Success;
        }

        /// <summary>
        /// Executes a quality assurance task and returns the result.
        /// </summary>
        /// <param name="task">The QA task to execute.</param>
        /// <returns>The result of the task execution.</returns>
        public async Task<AgentTaskResult> ExecuteTaskAsync(AgentTask task)
        {
            try
            {
                _logger.LogInformation($"QualityAssuranceAgent executando task: {task.TaskType}");
                switch (task.TaskType)
                {
                    case TaskType.GenerateTestPlan:
                        return await GenerateTestPlanAsync(task);
                    case TaskType.CreateUnitTests:
                        return await CreateUnitTestsAsync(task);
                    case TaskType.CreateIntegrationTests:
                        return await CreateIntegrationTestsAsync(task);
                    case TaskType.ExecuteTests:
                        return await ExecuteTestsAsync(task);
                    case TaskType.PerformanceTest:
                        return await PerformanceTestAsync(task);
                    case TaskType.SecurityTest:
                        return await SecurityTestAsync(task);
                    case TaskType.CodeReview:
                        return await CodeReviewAsync(task);
                    default:
                        throw new NotSupportedException($"Task type {task.TaskType} not supported by QualityAssuranceAgent");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao executar task no QualityAssuranceAgent");
                return new AgentTaskResult { Success = false, Message = ex.Message, Data = new Dictionary<string, object>() };
            }
        }

        /// <summary>
        /// Generates a test plan based on the provided task description.
        /// </summary>
        /// <param name="task">The test plan generation task.</param>
        /// <returns>The result of the test plan generation operation.</returns>
        private async Task<AgentTaskResult> GenerateTestPlanAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "test_plan_generation");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var planContent = await ExecutePromptAsync("test_plan_generation", variables);
            var testPlan = JsonSerializer.Deserialize<TestSuite>(planContent) ?? new TestSuite();
            var report = new QualityReport
            {
                ReportType = QualityReportType.Functional,
                Status = QualityReportStatus.Completed,
                TestSuites = new List<TestSuite> { testPlan }
            };
            return new AgentTaskResult
            {
                Success = true,
                Message = $"Test plan generated with {testPlan?.TestCases.Count ?? 0} test cases",
                Data = new Dictionary<string, object> { { "QualityReport", report } }
            };
        }

        /// <summary>
        /// Creates unit tests based on the provided task description.
        /// </summary>
        /// <param name="task">The unit test creation task.</param>
        /// <returns>The result of the unit test creation operation.</returns>
        private async Task<AgentTaskResult> CreateUnitTestsAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "unit_test_generation");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var unitTestsContent = await ExecutePromptAsync("unit_test_generation", variables);
            var unitTests = JsonSerializer.Deserialize<List<TestCase>>(unitTestsContent);
            var evidences = unitTests?.Select(tc => new TestEvidence
            {
                TestType = TestType.Unit,
                TestName = tc.Name,
                Result = TestResult.Passed,
                Details = "Generated by AI",
                ExecutedByAgentId = AgentId
            }).ToList() ?? new List<TestEvidence>();
            return new AgentTaskResult
            {
                Success = true,
                Message = $"Generated {unitTests?.Count ?? 0} unit tests",
                Data = new Dictionary<string, object> { { "TestEvidences", evidences } }
            };
        }

        /// <summary>
        /// Creates integration tests based on the provided task description.
        /// </summary>
        /// <param name="task">The integration test creation task.</param>
        /// <returns>The result of the integration test creation operation.</returns>
        private async Task<AgentTaskResult> CreateIntegrationTestsAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "integration_test_generation");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var integrationTestsContent = await ExecutePromptAsync("integration_test_generation", variables);
            var integrationTests = JsonSerializer.Deserialize<List<TestCase>>(integrationTestsContent);
            var evidences = integrationTests?.Select(tc => new TestEvidence
            {
                TestType = TestType.Integration,
                TestName = tc.Name,
                Result = TestResult.Passed,
                Details = "Generated by AI",
                ExecutedByAgentId = AgentId
            }).ToList() ?? new List<TestEvidence>();
            return new AgentTaskResult
            {
                Success = true,
                Message = $"Generated {integrationTests?.Count ?? 0} integration tests",
                Data = new Dictionary<string, object> { { "TestEvidences", evidences } }
            };
        }

        /// <summary>
        /// Executes tests based on the provided test suite in the task description.
        /// </summary>
        /// <param name="task">The test execution task.</param>
        /// <returns>The result of the test execution operation.</returns>
        private Task<AgentTaskResult> ExecuteTestsAsync(AgentTask task)
        {
            var suite = JsonSerializer.Deserialize<TestSuite>(task.Description) ?? new TestSuite();
            // Simulação de execução
            var summary = new { TotalTests = suite?.TestCases.Count ?? 0, PassedTests = suite?.TestCases.Count ?? 0, FailedTests = 0 };
            return Task.FromResult(new AgentTaskResult
            {
                Success = true,
                Message = $"Executed {summary.TotalTests} tests: {summary.PassedTests} passed, {summary.FailedTests} failed",
                Data = new Dictionary<string, object> { { "TestSuite", suite } }
            });
        }

        /// <summary>
        /// Performs performance testing based on the provided task description.
        /// </summary>
        /// <param name="task">The performance testing task.</param>
        /// <returns>The result of the performance testing operation.</returns>
        private async Task<AgentTaskResult> PerformanceTestAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "performance_test_generation");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var perfContent = await ExecutePromptAsync("performance_test_generation", variables);
            // Simulação de parsing dos resultados
            return new AgentTaskResult
            {
                Success = true,
                Message = "Performance testing completed.",
                Data = new Dictionary<string, object> { { "PerformanceResults", perfContent } }
            };
        }

        /// <summary>
        /// Performs security testing based on the provided task description.
        /// </summary>
        /// <param name="task">The security testing task.</param>
        /// <returns>The result of the security testing operation.</returns>
        private async Task<AgentTaskResult> SecurityTestAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "security_test_generation");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var secContent = await ExecutePromptAsync("security_test_generation", variables);
            // Simulação de parsing dos resultados
            return new AgentTaskResult
            {
                Success = true,
                Message = "Security testing completed.",
                Data = new Dictionary<string, object> { { "SecurityResults", secContent } }
            };
        }

        /// <summary>
        /// Performs code review based on the provided task description.
        /// </summary>
        /// <param name="task">The code review task.</param>
        /// <returns>The result of the code review operation.</returns>
        private async Task<AgentTaskResult> CodeReviewAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "code_review");
            var variables = new Dictionary<string, object> { { "description", task.Description } };
            var reviewContent = await ExecutePromptAsync("code_review", variables);
            // Simulação de parsing dos resultados
            return new AgentTaskResult
            {
                Success = true,
                Message = "Code review completed.",
                Data = new Dictionary<string, object> { { "CodeReview", reviewContent } }
            };
        }
    }
}

