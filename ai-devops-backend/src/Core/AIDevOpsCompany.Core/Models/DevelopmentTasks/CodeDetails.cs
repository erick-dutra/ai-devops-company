namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents detailed information about code, including language, technologies, frameworks, files, scripts, configuration, architecture, dependencies, and instructions.
    /// </summary>
    public class CodeDetails
    {
        /// <summary>
        /// The primary programming language used in the codebase.
        /// </summary>
        public string PrimaryLanguage { get; set; } = string.Empty;

        /// <summary>
        /// The list of technologies used in the codebase.
        /// </summary>
        public List<string> Technologies { get; set; } = new();

        /// <summary>
        /// The list of frameworks used in the codebase.
        /// </summary>
        public List<string> Frameworks { get; set; } = new();

        /// <summary>
        /// The list of code files included in the codebase.
        /// </summary>
        public List<CodeFile> Files { get; set; } = new();

        /// <summary>
        /// The list of database scripts associated with the codebase.
        /// </summary>
        public List<DatabaseScript> DatabaseScripts { get; set; } = new();

        /// <summary>
        /// The list of configuration files for the codebase.
        /// </summary>
        public List<ConfigurationFile> ConfigurationFiles { get; set; } = new();

        /// <summary>
        /// The architectural pattern used in the codebase.
        /// </summary>
        public ArchitecturalPattern ArchitecturalPattern { get; set; } = new();

        /// <summary>
        /// The list of dependencies required by the codebase.
        /// </summary>
        public List<Dependency> Dependencies { get; set; } = new();

        /// <summary>
        /// Instructions for building the codebase.
        /// </summary>
        public string BuildInstructions { get; set; } = string.Empty;

        /// <summary>
        /// Instructions for deploying the codebase.
        /// </summary>
        public string DeploymentInstructions { get; set; } = string.Empty;
    }
}
