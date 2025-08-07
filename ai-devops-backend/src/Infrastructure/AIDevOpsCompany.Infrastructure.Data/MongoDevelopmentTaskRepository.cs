using MongoDB.Driver;
using Microsoft.Extensions.Options;
using AIDevOpsCompany.Core.Models.DevelopmentTasks;
using AIDevOpsCompany.Core.Interfaces;

namespace AIDevOpsCompany.Infrastructure.Data
{
    /// <summary>
    /// Repository for managing development tasks in MongoDB.
    /// </summary>
    public class MongoDevelopmentTaskRepository : IDevelopmentTaskRepository
    {
        /// <summary>
        /// MongoDB collection for development tasks.
        /// </summary>
        private readonly IMongoCollection<DevelopmentTask> _developmentTasks;

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDevelopmentTaskRepository"/> class using MongoDB settings.
        /// </summary>
        /// <param name="settings">The MongoDB settings.</param>
        public MongoDevelopmentTaskRepository(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _developmentTasks = database.GetCollection<DevelopmentTask>("development_tasks");
        }

        /// <summary>
        /// Retrieves a development task by its ID.
        /// </summary>
        /// <param name="id">The task ID.</param>
        /// <returns>The matching <see cref="DevelopmentTask"/>, or null if not found.</returns>
        public async Task<DevelopmentTask?> GetByIdAsync(string id)
        {
            return await _developmentTasks.Find(t => t.TaskId == id).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Retrieves all development tasks.
        /// </summary>
        /// <returns>A list of <see cref="DevelopmentTask"/> objects.</returns>
        public async Task<List<DevelopmentTask>> GetAllAsync()
        {
            return await _developmentTasks.Find(_ => true).ToListAsync();
        }

        /// <summary>
        /// Inserts a new development task into the collection.
        /// </summary>
        /// <param name="task">The development task to insert.</param>
        public async Task CreateAsync(DevelopmentTask task)
        {
            await _developmentTasks.InsertOneAsync(task);
        }

        /// <summary>
        /// Updates an existing development task in the collection.
        /// </summary>
        /// <param name="task">The development task to update.</param>
        public async Task UpdateAsync(DevelopmentTask task)
        {
            await _developmentTasks.ReplaceOneAsync(t => t.TaskId == task.TaskId, task);
        }

        /// <summary>
        /// Deletes a development task by its ID.
        /// </summary>
        /// <param name="id">The task ID.</param>
        public async Task DeleteAsync(string id)
        {
            await _developmentTasks.DeleteOneAsync(t => t.TaskId == id);
        }

        /// <summary>
        /// Retrieves development tasks by project ID.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>A list of <see cref="DevelopmentTask"/> objects for the specified project.</returns>
        public async Task<List<DevelopmentTask>> GetByProjectIdAsync(string projectId)
        {
            return await _developmentTasks.Find(t => t.ProjectId == projectId).ToListAsync();
        }

        /// <summary>
        /// Retrieves development tasks by their status.
        /// </summary>
        /// <param name="status">The task status.</param>
        /// <returns>A list of <see cref="DevelopmentTask"/> objects with the specified status.</returns>
        public async Task<List<DevelopmentTask>> GetByStatusAsync(TaskStatus status)
        {
            return await _developmentTasks.Find(t => t.Status.Equals(status)).ToListAsync();
        }
    }
}

