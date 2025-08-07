using AIDevOpsCompany.Core.Models.Projects;

namespace AIDevOpsCompany.Core.Interfaces
{
    /// <summary>
    /// Represents a repository interface for managing projects.
    /// </summary>
    public interface IProjectRepository
    {
        /// <summary>
        /// Gets a project by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the project.</param>
        /// <returns>The project if found; otherwise, null.</returns>
        Task<Project?> GetByIdAsync(string id);

        /// <summary>
        /// Gets all projects asynchronously.
        /// </summary>
        /// <returns>A list of all projects.</returns>
        Task<List<Project>> GetAllAsync();

        /// <summary>
        /// Creates a new project asynchronously.
        /// </summary>
        /// <param name="project">The project to create.</param>
        Task CreateAsync(Project project);

        /// <summary>
        /// Updates an existing project asynchronously.
        /// </summary>
        /// <param name="project">The project to update.</param>
        Task UpdateAsync(Project project);

        /// <summary>
        /// Deletes a project by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the project to delete.</param>
        Task DeleteAsync(string id);

        /// <summary>
        /// Gets all projects by their status asynchronously.
        /// </summary>
        /// <param name="status">The status of the projects.</param>
        /// <returns>A list of projects with the specified status.</returns>
        Task<List<Project>> GetByStatusAsync(ProjectStatus status);
    }
}
