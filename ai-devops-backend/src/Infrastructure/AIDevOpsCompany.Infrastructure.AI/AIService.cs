using Microsoft.Extensions.Logging;

namespace AIDevOpsCompany.Infrastructure.AI
{
    /// <summary>
    /// Provides AI-powered services for project management, code generation, infrastructure analysis, and more.
    /// </summary>
    public class AIService : IAIService
    {
        /// <summary>
        /// Client for interacting with Llama-based AI models.
        /// </summary>
        private readonly ILlamaClient _llamaClient;
        /// <summary>
        /// Logger for AI service operations.
        /// </summary>
        private readonly ILogger<AIService> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="AIService"/> class.
        /// </summary>
        /// <param name="llamaClient">The Llama client for AI operations.</param>
        /// <param name="logger">The logger instance.</param>
        public AIService(ILlamaClient llamaClient, ILogger<AIService> logger)
        {
            _llamaClient = llamaClient;
            _logger = logger;
        }

        /// <summary>
        /// Processes a project management task using AI and returns a detailed response.
        /// </summary>
        /// <param name="task">The project management task description.</param>
        /// <param name="context">Optional context for the task.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated project management response.</returns>
        public async Task<string> ProcessProjectManagementTaskAsync(string task, string context = "", CancellationToken cancellationToken = default)
        {
            var prompt = $@"You are an experienced project manager for a software development company. 

Task: {task}
Context: {context}

Please provide a detailed response that includes:
1. Analysis of the task
2. Recommended approach
3. Timeline estimation
4. Resource requirements
5. Risk assessment
6. Success criteria

Response:";

            return await _llamaClient.GenerateResponseAsync(prompt, "llama2:7b", cancellationToken);
        }

        /// <summary>
        /// Analyzes requirements using AI and returns insights or suggestions.
        /// </summary>
        /// <param name="requirements">The requirements to analyze.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated requirements analysis.</returns>
        public async Task<string> AnalyzeRequirementsAsync(string requirements, CancellationToken cancellationToken = default)
        {
            return await _llamaClient.AnalyzeRequirementsAsync(requirements, cancellationToken);
        }

        /// <summary>
        /// Generates code based on requirements and target language using AI.
        /// </summary>
        /// <param name="requirements">The requirements for code generation.</param>
        /// <param name="language">Target programming language.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated code.</returns>
        public async Task<string> GenerateCodeAsync(string requirements, string language = "csharp", CancellationToken cancellationToken = default)
        {
            return await _llamaClient.GenerateCodeAsync(requirements, language, cancellationToken);
        }

        /// <summary>
        /// Reviews code using AI and returns suggestions or improvements.
        /// </summary>
        /// <param name="code">The code to review.</param>
        /// <param name="language">Programming language of the code.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated code review.</returns>
        public async Task<string> ReviewCodeAsync(string code, string language = "csharp", CancellationToken cancellationToken = default)
        {
            return await _llamaClient.ReviewCodeAsync(code, language, cancellationToken);
        }

        /// <summary>
        /// Generates tests for the provided code using AI.
        /// </summary>
        /// <param name="code">The code to generate tests for.</param>
        /// <param name="language">Programming language of the code.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated test code.</returns>
        public async Task<string> GenerateTestsAsync(string code, string language = "csharp", CancellationToken cancellationToken = default)
        {
            return await _llamaClient.GenerateTestsAsync(code, language, cancellationToken);
        }

        /// <summary>
        /// Analyzes infrastructure configuration using AI and returns an assessment.
        /// </summary>
        /// <param name="infrastructure">The infrastructure configuration to analyze.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated infrastructure analysis.</returns>
        public async Task<string> AnalyzeInfrastructureAsync(string infrastructure, CancellationToken cancellationToken = default)
        {
            var prompt = $@"You are a senior DevOps engineer. Analyze the following infrastructure configuration:

{infrastructure}

Please provide:
1. Architecture assessment
2. Scalability analysis
3. Security considerations
4. Performance optimization suggestions
5. Cost optimization recommendations
6. Best practices compliance
7. Potential issues and solutions

Analysis:";

            return await _llamaClient.GenerateResponseAsync(prompt, "mistral:7b", cancellationToken);
        }

        /// <summary>
        /// Generates a deployment script for a specified platform using AI.
        /// </summary>
        /// <param name="requirements">Deployment requirements.</param>
        /// <param name="platform">Target deployment platform.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated deployment script.</returns>
        public async Task<string> GenerateDeploymentScriptAsync(string requirements, string platform = "docker", CancellationToken cancellationToken = default)
        {
            var prompt = $@"You are a DevOps automation expert. Generate a deployment script for {platform} based on these requirements:

{requirements}

Generate a complete, production-ready deployment script that includes:
- Environment setup
- Dependencies installation
- Configuration management
- Health checks
- Rollback procedures
- Monitoring setup

Script:";

            return await _llamaClient.GenerateResponseAsync(prompt, "mistral:7b", cancellationToken);
        }

        /// <summary>
        /// Analyzes code for security issues using AI.
        /// </summary>
        /// <param name="code">The code to analyze for security.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated security analysis.</returns>
        public async Task<string> AnalyzeSecurityAsync(string code, CancellationToken cancellationToken = default)
        {
            return await _llamaClient.AnalyzeSecurityAsync(code, cancellationToken);
        }

        /// <summary>
        /// Generates monitoring configuration for services using AI.
        /// </summary>
        /// <param name="services">Service definitions for monitoring.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated monitoring configuration.</returns>
        public async Task<string> GenerateMonitoringConfigAsync(string services, CancellationToken cancellationToken = default)
        {
            var prompt = $@"You are a monitoring and observability expert. Generate monitoring configuration for the following services:

{services}

Create comprehensive monitoring setup including:
1. Metrics collection configuration
2. Alerting rules
3. Dashboard definitions
4. Log aggregation setup
5. Health check endpoints
6. SLA/SLO definitions
7. Incident response procedures

Configuration:";

            return await _llamaClient.GenerateResponseAsync(prompt, "llama2:7b", cancellationToken);
        }

        /// <summary>
        /// Processes financial data and tasks using AI and returns analysis and recommendations.
        /// </summary>
        /// <param name="data">Financial data to analyze.</param>
        /// <param name="task">Financial task description.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated financial analysis.</returns>
        public async Task<string> ProcessFinancialDataAsync(string data, string task, CancellationToken cancellationToken = default)
        {
            var prompt = $@"You are a financial analyst specializing in software development projects. 

Data: {data}
Task: {task}

Please provide:
1. Financial analysis
2. Cost breakdown
3. Budget recommendations
4. ROI calculations
5. Risk assessment
6. Optimization suggestions

Analysis:";

            return await _llamaClient.GenerateResponseAsync(prompt, "llama2:7b", cancellationToken);
        }

        /// <summary>
        /// Processes an HR task using AI and returns recommendations and analysis.
        /// </summary>
        /// <param name="task">HR task description.</param>
        /// <param name="context">Optional context for the HR task.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>AI-generated HR analysis and recommendations.</returns>
        public async Task<string> ProcessHRTaskAsync(string task, string context = "", CancellationToken cancellationToken = default)
        {
            var prompt = $@"You are an HR specialist for a technology company.

Task: {task}
Context: {context}

Please provide:
1. Analysis of the HR task
2. Recommended actions
3. Policy considerations
4. Legal compliance notes
5. Best practices
6. Implementation steps

Response:";

            return await _llamaClient.GenerateResponseAsync(prompt, "llama2:7b", cancellationToken);
        }

        /// <summary>
        /// Checks if the AI service is available and healthy.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True if the service is available; otherwise, false.</returns>
        public async Task<bool> IsAvailableAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _llamaClient.IsHealthyAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error checking AI service availability");
                return false;
            }
        }
    }
}

