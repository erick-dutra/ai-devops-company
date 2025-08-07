using Microsoft.AspNetCore.Mvc;
using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Models.Agents.Prompts;

namespace AIDevOpsCompany.API.Controllers
{
    /// <summary>
    /// API controller for managing agent prompts.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PromptsController : ControllerBase
    {
        /// <summary>
        /// Repository for accessing and managing prompts.
        /// </summary>
        private readonly IPromptRepository _promptRepository;

        /// <summary>
        /// Logger for logging controller operations.
        /// </summary>
        private readonly ILogger<PromptsController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptsController"/> class.
        /// </summary>
        /// <param name="promptRepository">The prompt repository.</param>
        /// <param name="logger">The logger instance.</param>
        public PromptsController(IPromptRepository promptRepository, ILogger<PromptsController> logger)
        {
            _promptRepository = promptRepository;
            _logger = logger;
        }

        /// <summary>
        /// Gets all prompts for a specific agent role.
        /// </summary>
        /// <param name="agentRole">The agent role.</param>
        /// <returns>A list of prompts for the specified agent role.</returns>
        [HttpGet("{agentRole}")]
        public async Task<ActionResult<List<AgentPrompt>>> GetPromptsForAgent(string agentRole)
        {
            try
            {
                var prompts = await _promptRepository.GetPromptsForAgentAsync(agentRole);
                return Ok(prompts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting prompts for agent role {AgentRole}", agentRole);
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Gets a specific prompt for an agent role by prompt name.
        /// </summary>
        /// <param name="agentRole">The agent role.</param>
        /// <param name="promptName">The prompt name.</param>
        /// <returns>The prompt if found; otherwise, NotFound.</returns>
        [HttpGet("{agentRole}/{promptName}")]
        public async Task<ActionResult<AgentPrompt>> GetPrompt(string agentRole, string promptName)
        {
            try
            {
                var prompt = await _promptRepository.GetPromptAsync(agentRole, promptName);
                if (prompt == null)
                {
                    return NotFound($"Prompt '{promptName}' not found for agent role '{agentRole}'");
                }
                return Ok(prompt);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting prompt {PromptName} for agent role {AgentRole}", promptName, agentRole);
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Creates a new prompt.
        /// </summary>
        /// <param name="prompt">The prompt to create.</param>
        /// <returns>The created prompt with its location.</returns>
        [HttpPost]
        public async Task<ActionResult> CreatePrompt([FromBody] AgentPrompt prompt)
        {
            try
            {
                prompt.PromptId = Guid.NewGuid().ToString();
                prompt.CreatedAt = DateTime.UtcNow;
                prompt.UpdatedAt = DateTime.UtcNow;
                
                await _promptRepository.SavePromptAsync(prompt);
                return CreatedAtAction(nameof(GetPrompt), new { agentRole = prompt.AgentRole, promptName = prompt.PromptName }, prompt);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating prompt");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Updates an existing prompt by its ID.
        /// </summary>
        /// <param name="promptId">The ID of the prompt to update.</param>
        /// <param name="prompt">The updated prompt data.</param>
        /// <returns>No content if successful.</returns>
        [HttpPut("{promptId}")]
        public async Task<ActionResult> UpdatePrompt(string promptId, [FromBody] AgentPrompt prompt)
        {
            try
            {
                prompt.PromptId = promptId;
                prompt.UpdatedAt = DateTime.UtcNow;
                
                await _promptRepository.UpdatePromptAsync(prompt);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating prompt {PromptId}", promptId);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

