using AIDevOpsCompany.Core.Models.DevelopmentTasks;

namespace AIDevOpsCompany.Core.Interfaces
{
    /// <summary>
    /// Represents a repository interface for managing development tasks.
    /// </summary>
    public interface IDevelopmentTaskRepository
    {
        /// <summary>
        /// Gets a development task by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the development task.</param>
        /// <returns>The development task if found; otherwise, null.</returns>
        Task<DevelopmentTask?> GetByIdAsync(string id);

        /// <summary>
        /// Gets all development tasks asynchronously.
        /// </summary>
        /// <returns>A list of all development tasks.</returns>
        Task<List<DevelopmentTask>> GetAllAsync();

        /// <summary>
        /// Creates a new development task asynchronously.
        /// </summary>
        /// <param name="task">The development task to create.</param>
        Task CreateAsync(DevelopmentTask task);

        /// <summary>
        /// Updates an existing development task asynchronously.
        /// </summary>
        /// <param name="task">The development task to update.</param>
        Task UpdateAsync(DevelopmentTask task);

        /// <summary>
        /// Deletes a development task by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the development task to delete.</param>
        Task DeleteAsync(string id);

        /// <summary>
        /// Gets all development tasks by project identifier asynchronously.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <returns>A list of development tasks for the specified project.</returns>
        Task<List<DevelopmentTask>> GetByProjectIdAsync(string projectId);

        /// <summary>
        /// Gets all development tasks by their status asynchronously.
        /// </summary>
        /// <param name="status">The status of the development tasks.</param>
        /// <returns>A list of development tasks with the specified status.</returns>
        Task<List<DevelopmentTask>> GetByStatusAsync(TaskStatus status);
    }
}
