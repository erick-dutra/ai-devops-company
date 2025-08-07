using MongoDB.Driver;
using Microsoft.Extensions.Options;
using AIDevOpsCompany.Core.Models.Projects;
using AIDevOpsCompany.Core.Interfaces;

namespace AIDevOpsCompany.Infrastructure.Data
{
    /// <summary>
    /// Repository for managing projects in MongoDB.
    /// </summary>
    public class MongoProjectRepository : IProjectRepository
    {
        /// <summary>
        /// MongoDB collection for projects.
        /// </summary>
        private readonly IMongoCollection<Project> _projects;

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoProjectRepository"/> class using MongoDB settings.
        /// </summary>
        /// <param name="settings">The MongoDB settings.</param>
        public MongoProjectRepository(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _projects = database.GetCollection<Project>("projects");
        }

        /// <summary>
        /// Retrieves a project by its ID.
        /// </summary>
        /// <param name="id">The project ID.</param>
        /// <returns>The matching <see cref="Project"/>, or null if not found.</returns>
        public async Task<Project?> GetByIdAsync(string id)
        {
            return await _projects.Find(p => p.ProjectId == id).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Retrieves all projects.
        /// </summary>
        /// <returns>A list of <see cref="Project"/> objects.</returns>
        public async Task<List<Project>> GetAllAsync()
        {
            return await _projects.Find(_ => true).ToListAsync();
        }

        /// <summary>
        /// Inserts a new project into the collection.
        /// </summary>
        /// <param name="project">The project to insert.</param>
        public async Task CreateAsync(Project project)
        {
            await _projects.InsertOneAsync(project);
        }

        /// <summary>
        /// Updates an existing project in the collection.
        /// </summary>
        /// <param name="project">The project to update.</param>
        public async Task UpdateAsync(Project project)
        {
            await _projects.ReplaceOneAsync(p => p.ProjectId == project.ProjectId, project);
        }

        /// <summary>
        /// Deletes a project by its ID.
        /// </summary>
        /// <param name="id">The project ID.</param>
        public async Task DeleteAsync(string id)
        {
            await _projects.DeleteOneAsync(p => p.ProjectId == id);
        }

        /// <summary>
        /// Retrieves projects by their status.
        /// </summary>
        /// <param name="status">The project status.</param>
        /// <returns>A list of <see cref="Project"/> objects with the specified status.</returns>
        public async Task<List<Project>> GetByStatusAsync(ProjectStatus status)
        {
            return await _projects.Find(p => p.Status == status).ToListAsync();
        }
    }
}

