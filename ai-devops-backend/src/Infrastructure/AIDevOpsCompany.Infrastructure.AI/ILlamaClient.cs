namespace AIDevOpsCompany.Infrastructure.AI
{
    /// <summary>
    /// Defines methods for interacting with a Llama-based AI model client, including text generation, code analysis, and health checks.
    /// </summary>
    public interface ILlamaClient
    {
        /// <summary>
        /// Generates a response from the Llama model based on the provided prompt and model name.
        /// </summary>
        /// <param name="prompt">The input prompt for the model.</param>
        /// <param name="model">The model name to use (default is "llama2:7b").</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the generated response as a string.</returns>
        Task<string> GenerateResponseAsync(string prompt, string model = "llama2:7b", CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates code in the specified programming language based on the provided prompt.
        /// </summary>
        /// <param name="prompt">The input prompt describing the code to generate.</param>
        /// <param name="language">The programming language for the generated code (default is "csharp").</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the generated code as a string.</returns>
        Task<string> GenerateCodeAsync(string prompt, string language = "csharp", CancellationToken cancellationToken = default);

        /// <summary>
        /// Analyzes software requirements and provides insights or suggestions.
        /// </summary>
        /// <param name="requirements">The requirements text to analyze.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the analysis as a string.</returns>
        Task<string> AnalyzeRequirementsAsync(string requirements, CancellationToken cancellationToken = default);

        /// <summary>
        /// Reviews the provided code and returns feedback or suggestions for improvement.
        /// </summary>
        /// <param name="code">The code to review.</param>
        /// <param name="language">The programming language of the code (default is "csharp").</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the review feedback as a string.</returns>
        Task<string> ReviewCodeAsync(string code, string language = "csharp", CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates unit tests for the provided code in the specified programming language.
        /// </summary>
        /// <param name="code">The code for which to generate tests.</param>
        /// <param name="language">The programming language for the tests (default is "csharp").</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the generated tests as a string.</returns>
        Task<string> GenerateTestsAsync(string code, string language = "csharp", CancellationToken cancellationToken = default);

        /// <summary>
        /// Analyzes the provided code for security vulnerabilities or issues.
        /// </summary>
        /// <param name="code">The code to analyze for security.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the security analysis as a string.</returns>
        Task<string> AnalyzeSecurityAsync(string code, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks the health status of the Llama client service.
        /// </summary>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result indicates whether the service is healthy.</returns>
        Task<bool> IsHealthyAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of available Llama models.
        /// </summary>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of available model names.</returns>
        Task<List<string>> GetAvailableModelsAsync(CancellationToken cancellationToken = default);
    }
}

