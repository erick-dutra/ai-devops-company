namespace AIDevOpsCompany.Infrastructure.AI
{
    /// <summary>
    /// Defines the contract for AI-powered services including project management, code generation, infrastructure analysis, and more.
    /// </summary>
    public interface IAIService
    {
        /// <summary>
        /// Processes a project management task using AI and returns a detailed response.
        /// </summary>
        Task<string> ProcessProjectManagementTaskAsync(string task, string context = "", CancellationToken cancellationToken = default);
        /// <summary>
        /// Analyzes requirements using AI and returns insights or suggestions.
        /// </summary>
        Task<string> AnalyzeRequirementsAsync(string requirements, CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates code based on requirements and target language using AI.
        /// </summary>
        Task<string> GenerateCodeAsync(string requirements, string language = "csharp", CancellationToken cancellationToken = default);
        /// <summary>
        /// Reviews code using AI and returns suggestions or improvements.
        /// </summary>
        Task<string> ReviewCodeAsync(string code, string language = "csharp", CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates tests for the provided code using AI.
        /// </summary>
        Task<string> GenerateTestsAsync(string code, string language = "csharp", CancellationToken cancellationToken = default);
        /// <summary>
        /// Analyzes infrastructure configuration using AI and returns an assessment.
        /// </summary>
        Task<string> AnalyzeInfrastructureAsync(string infrastructure, CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates a deployment script for a specified platform using AI.
        /// </summary>
        Task<string> GenerateDeploymentScriptAsync(string requirements, string platform = "docker", CancellationToken cancellationToken = default);
        /// <summary>
        /// Analyzes code for security issues using AI.
        /// </summary>
        Task<string> AnalyzeSecurityAsync(string code, CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates monitoring configuration for services using AI.
        /// </summary>
        Task<string> GenerateMonitoringConfigAsync(string services, CancellationToken cancellationToken = default);
        /// <summary>
        /// Processes financial data and tasks using AI and returns analysis and recommendations.
        /// </summary>
        Task<string> ProcessFinancialDataAsync(string data, string task, CancellationToken cancellationToken = default);
        /// <summary>
        /// Processes an HR task using AI and returns recommendations and analysis.
        /// </summary>
        Task<string> ProcessHRTaskAsync(string task, string context = "", CancellationToken cancellationToken = default);
        /// <summary>
        /// Checks if the AI service is available and healthy.
        /// </summary>
        Task<bool> IsAvailableAsync(CancellationToken cancellationToken = default);
    }
}

