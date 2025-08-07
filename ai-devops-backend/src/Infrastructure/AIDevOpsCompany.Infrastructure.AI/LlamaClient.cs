using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AIDevOpsCompany.Infrastructure.AI
{
    /// <summary>
    /// Provides an implementation of the <see cref="ILlamaClient"/> interface for interacting with the Llama API service.
    /// </summary>
    public class LlamaClient : ILlamaClient
    {
        /// <summary>
        /// The HTTP client used for making requests to the Llama API.
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Logger for logging errors and information.
        /// </summary>
        private readonly ILogger<LlamaClient> _logger;

        /// <summary>
        /// Configuration settings for the Llama client.
        /// </summary>
        private readonly LlamaSettings _settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaClient"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client to use for requests.</param>
        /// <param name="settings">The Llama client settings.</param>
        /// <param name="logger">The logger instance.</param>
        public LlamaClient(HttpClient httpClient, IOptions<LlamaSettings> settings, ILogger<LlamaClient> logger)
        {
            _httpClient = httpClient;
            _settings = settings.Value;
            _logger = logger;

            _httpClient.BaseAddress = new Uri(_settings.BaseUrl);
            _httpClient.Timeout = TimeSpan.FromSeconds(_settings.Timeout);
        }

        /// <summary>
        /// Generates a response from the Llama model based on the provided prompt and model name.
        /// </summary>
        /// <param name="prompt">The prompt to send to the Llama model.</param>
        /// <param name="model">The name of the Llama model to use. Default is "llama2:7b".</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The generated response as a string.</returns>
        public async Task<string> GenerateResponseAsync(string prompt, string model = "llama2:7b", CancellationToken cancellationToken = default)
        {
            try
            {
                var request = new LlamaGenerateRequest
                {
                    Model = model,
                    Prompt = prompt,
                    Stream = false,
                    Options = new LlamaOptions
                    {
                        Temperature = 0.3,
                        TopP = 0.9,
                        TopK = 40,
                        NumCtx = 4096
                    }
                };

                var response = await SendRequestAsync<LlamaGenerateRequest, LlamaGenerateResponse>(
                    "/api/generate", request, cancellationToken);

                return response?.Response ?? string.Empty;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating response with model {Model}", model);
                throw;
            }
        }

        /// <summary>
        /// Generates code in the specified language using the Llama model based on the provided prompt.
        /// </summary>
        /// <param name="prompt">The requirements or description for the code to generate.</param>
        /// <param name="language">The programming language for the generated code. Default is "csharp".</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The generated code as a string.</returns>
        public async Task<string> GenerateCodeAsync(string prompt, string language = "csharp", CancellationToken cancellationToken = default)
        {
            var codePrompt = $@"You are an expert {language} developer. Generate clean, well-documented, and production-ready code based on the following requirements:

{prompt}

Requirements:
- Follow best practices and coding standards
- Include proper error handling
- Add comprehensive comments
- Use appropriate design patterns
- Ensure code is testable and maintainable

Generate only the code without explanations:";

            return await GenerateResponseAsync(codePrompt, "codellama:7b", cancellationToken);
        }

        /// <summary>
        /// Analyzes software requirements and provides insights or suggestions using the Llama model.
        /// </summary>
        /// <param name="requirements">The requirements to analyze.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The analysis result as a string.</returns>
        public async Task<string> AnalyzeRequirementsAsync(string requirements, CancellationToken cancellationToken = default)
        {
            var analysisPrompt = $@"You are a senior business analyst. Analyze the following requirements and provide a detailed breakdown:

{requirements}

Please provide:
1. Functional requirements breakdown
2. Non-functional requirements identification
3. Potential risks and challenges
4. Recommended implementation approach
5. Acceptance criteria suggestions

Analysis:";

            return await GenerateResponseAsync(analysisPrompt, "llama2:13b", cancellationToken);
        }

        /// <summary>
        /// Reviews the provided code in the specified language and returns feedback or suggestions.
        /// </summary>
        /// <param name="code">The code to review.</param>
        /// <param name="language">The programming language of the code. Default is "csharp".</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The code review feedback as a string.</returns>
        public async Task<string> ReviewCodeAsync(string code, string language = "csharp", CancellationToken cancellationToken = default)
        {
            var reviewPrompt = $@"You are a senior {language} developer conducting a code review. Review the following code and provide feedback:

```{language}
{code}
```

Please analyze:
1. Code quality and best practices
2. Potential bugs or issues
3. Performance considerations
4. Security vulnerabilities
5. Maintainability and readability
6. Suggestions for improvement

Code Review:";

            return await GenerateResponseAsync(reviewPrompt, "llama2:13b", cancellationToken);
        }

        /// <summary>
        /// Generates unit or integration tests for the provided code in the specified language.
        /// </summary>
        /// <param name="code">The code to generate tests for.</param>
        /// <param name="language">The programming language for the tests. Default is "csharp".</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The generated test code as a string.</returns>
        public async Task<string> GenerateTestsAsync(string code, string language = "csharp", CancellationToken cancellationToken = default)
        {
            var testPrompt = $@"You are a QA engineer specializing in {language}. Generate comprehensive unit tests for the following code:

```{language}
{code}
```

Generate tests that cover:
- Happy path scenarios
- Edge cases
- Error conditions
- Boundary values
- Mock dependencies where appropriate

Use appropriate testing framework for {language}. Generate only the test code:";

            return await GenerateResponseAsync(testPrompt, "codellama:7b", cancellationToken);
        }

        /// <summary>
        /// Analyzes the provided code for security vulnerabilities and provides recommendations.
        /// </summary>
        /// <param name="code">The code to analyze for security issues.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The security analysis as a string.</returns>
        public async Task<string> AnalyzeSecurityAsync(string code, CancellationToken cancellationToken = default)
        {
            var securityPrompt = $@"You are a cybersecurity expert. Analyze the following code for security vulnerabilities:

```
{code}
```

Please identify:
1. Security vulnerabilities (OWASP Top 10)
2. Input validation issues
3. Authentication/authorization problems
4. Data exposure risks
5. Injection attack vectors
6. Cryptographic issues
7. Recommendations for fixes

Security Analysis:";

            return await GenerateResponseAsync(securityPrompt, "llama2:13b", cancellationToken);
        }

        /// <summary>
        /// Checks the health status of the Llama service or client.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>True if the service is healthy; otherwise, false.</returns>
        public async Task<bool> IsHealthyAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _httpClient.GetAsync("/api/tags", cancellationToken);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "LLAMA health check failed");
                return false;
            }
        }

        /// <summary>
        /// Retrieves a list of available Llama models that can be used for inference.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of available model names.</returns>
        public async Task<List<string>> GetAvailableModelsAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                var response = await _httpClient.GetAsync("/api/tags", cancellationToken);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync(cancellationToken);
                var modelsResponse = JsonSerializer.Deserialize<LlamaModelsResponse>(content);

                return modelsResponse?.Models?.Select(m => m.Name).ToList() ?? new List<string>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting available models");
                return new List<string>();
            }
        }

        /// <summary>
        /// Sends a POST request to the Llama API and deserializes the response.
        /// </summary>
        /// <typeparam name="TRequest">The request type.</typeparam>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="endpoint">The API endpoint.</param>
        /// <param name="request">The request object.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The deserialized response object, or null if deserialization fails.</returns>
        private async Task<TResponse?> SendRequestAsync<TRequest, TResponse>(string endpoint, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : class
            where TResponse : class
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(endpoint, content, cancellationToken);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
            return JsonSerializer.Deserialize<TResponse>(responseContent);
        }
    }

    /// <summary>
    /// Represents configuration settings for the Llama client.
    /// </summary>
    public class LlamaSettings
    {
        /// <summary>
        /// The base URL of the Llama API service.
        /// </summary>
        public string BaseUrl { get; set; } = "http://localhost:11434";

        /// <summary>
        /// Timeout in seconds for HTTP requests.
        /// </summary>
        public int Timeout { get; set; } = 300;

        /// <summary>
        /// The default Llama model to use for inference.
        /// </summary>
        public string DefaultModel { get; set; } = "llama2:7b";
    }

    /// <summary>
    /// Represents a request to generate a response from the Llama model.
    /// </summary>
    public class LlamaGenerateRequest
    {
        /// <summary>
        /// The name of the Llama model to use.
        /// </summary>
        public string Model { get; set; } = string.Empty;

        /// <summary>
        /// The prompt to send to the Llama model.
        /// </summary>
        public string Prompt { get; set; } = string.Empty;

        /// <summary>
        /// Whether to stream the response.
        /// </summary>
        public bool Stream { get; set; } = false;

        /// <summary>
        /// Additional options for the Llama model.
        /// </summary>
        public LlamaOptions? Options { get; set; }
    }

    /// <summary>
    /// Represents additional options for the Llama model.
    /// </summary>
    public class LlamaOptions
    {
        /// <summary>
        /// Sampling temperature for response generation.
        /// </summary>
        public double Temperature { get; set; } = 0.3;

        /// <summary>
        /// Nucleus sampling probability.
        /// </summary>
        public double TopP { get; set; } = 0.9;

        /// <summary>
        /// Top-K sampling parameter.
        /// </summary>
        public int TopK { get; set; } = 40;

        /// <summary>
        /// Number of context tokens.
        /// </summary>
        public int NumCtx { get; set; } = 4096;
    }

    /// <summary>
    /// Represents a response from the Llama model generation API.
    /// </summary>
    public class LlamaGenerateResponse
    {
        /// <summary>
        /// The name of the Llama model used.
        /// </summary>
        public string Model { get; set; } = string.Empty;

        /// <summary>
        /// The generated response from the model.
        /// </summary>
        public string Response { get; set; } = string.Empty;

        /// <summary>
        /// Indicates if the response is complete.
        /// </summary>
        public bool Done { get; set; }

        /// <summary>
        /// The creation timestamp of the response.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }

    /// <summary>
    /// Represents a response containing available Llama models.
    /// </summary>
    public class LlamaModelsResponse
    {
        /// <summary>
        /// List of available Llama models.
        /// </summary>
        public List<LlamaModel>? Models { get; set; }
    }

    /// <summary>
    /// Represents a Llama model.
    /// </summary>
    public class LlamaModel
    {
        /// <summary>
        /// The name of the Llama model.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The last modified timestamp of the model.
        /// </summary>
        public DateTime ModifiedAt { get; set; }

        /// <summary>
        /// The size of the model in bytes.
        /// </summary>
        public long Size { get; set; }
    }
}

