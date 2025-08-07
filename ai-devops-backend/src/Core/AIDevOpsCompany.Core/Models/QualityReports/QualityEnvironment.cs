namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents the technical environment in which quality tests were executed.
    /// </summary>
    public class QualityEnvironment
    {
        /// <summary>
        /// Unique identifier for the environment.
        /// </summary>
        public string EnvironmentId { get; set; } = string.Empty;
        
        /// <summary>
        /// Name of the environment (e.g., "Development", "Testing", "Staging").
        /// </summary>
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// Operating system details including version.
        /// </summary>
        public string OperatingSystem { get; set; } = string.Empty;
        
        /// <summary>
        /// Web browser used for testing (if applicable).
        /// </summary>
        public string Browser { get; set; } = string.Empty;
        
        /// <summary>
        /// Version of the web browser used for testing.
        /// </summary>
        public string BrowserVersion { get; set; } = string.Empty;
        
        /// <summary>
        /// Version of the application under test.
        /// </summary>
        public string ApplicationVersion { get; set; } = string.Empty;
        
        /// <summary>
        /// Version of the database used by the application.
        /// </summary>
        public string DatabaseVersion { get; set; } = string.Empty;
        
        /// <summary>
        /// Environment variables active during the test execution.
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables { get; set; } = new();
        
        /// <summary>
        /// List of relevant software installed in the test environment.
        /// </summary>
        public List<string> InstalledSoftware { get; set; } = new();
    }
}
