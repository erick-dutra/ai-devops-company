using Microsoft.Extensions.Options;
using MongoDB.Driver;
using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Models.Agents.Prompts;

namespace AIDevOpsCompany.Infrastructure.Data
{
    /// <summary>
    /// Represents MongoDB configuration settings.
    /// </summary>
    public class MongoDbSettings
    {
        /// <summary>
        /// The MongoDB connection string.
        /// </summary>
        public string ConnectionString { get; set; } = string.Empty;

        /// <summary>
        /// The name of the MongoDB database.
        /// </summary>
        public string DatabaseName { get; set; } = string.Empty;
    }

    /// <summary>
    /// Repository for managing agent prompts in MongoDB.
    /// </summary>
    public class MongoPromptRepository : IPromptRepository
    {
        /// <summary>
        /// MongoDB collection for agent prompts.
        /// </summary>
        private readonly IMongoCollection<AgentPrompt> _prompts;

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoPromptRepository"/> class using MongoDB settings.
        /// </summary>
        /// <param name="settings">The MongoDB settings.</param>
        public MongoPromptRepository(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _prompts = database.GetCollection<AgentPrompt>("agent_prompts");
        }

        /// <summary>
        /// Retrieves a prompt for a specific agent role and prompt name.
        /// </summary>
        /// <param name="agentRole">The agent role.</param>
        /// <param name="promptName">The prompt name.</param>
        /// <returns>The matching <see cref="AgentPrompt"/>, or null if not found.</returns>
        public async Task<AgentPrompt?> GetPromptAsync(string agentRole, string promptName)
        {
            return await _prompts
                .Find(p => p.AgentRole == agentRole && p.PromptName == promptName)
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Retrieves all prompts for a specific agent role.
        /// </summary>
        /// <param name="agentRole">The agent role.</param>
        /// <returns>A list of <see cref="AgentPrompt"/> objects.</returns>
        public async Task<List<AgentPrompt>> GetPromptsForAgentAsync(string agentRole)
        {
            return await _prompts
                .Find(p => p.AgentRole == agentRole)
                .ToListAsync();
        }

        /// <summary>
        /// Saves a new agent prompt to the collection.
        /// </summary>
        /// <param name="prompt">The agent prompt to save.</param>
        public async Task SavePromptAsync(AgentPrompt prompt)
        {
            await _prompts.InsertOneAsync(prompt);
        }

        /// <summary>
        /// Updates an existing agent prompt in the collection.
        /// </summary>
        /// <param name="prompt">The agent prompt to update.</param>
        public async Task UpdatePromptAsync(AgentPrompt prompt)
        {
            await _prompts.ReplaceOneAsync(
                p => p.PromptId == prompt.PromptId,
                prompt);
        }
    }
}

