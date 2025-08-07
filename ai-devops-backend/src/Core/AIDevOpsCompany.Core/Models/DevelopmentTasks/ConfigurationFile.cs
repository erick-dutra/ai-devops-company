namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a configuration file, including its metadata, type, content, environment, settings, and encryption status.
    /// </summary>
    public class ConfigurationFile
    {
        /// <summary>
        /// The unique identifier for the configuration file.
        /// </summary>
        public string ConfigId { get; set; } = string.Empty;

        /// <summary>
        /// The name of the configuration file.
        /// </summary>
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// The type of configuration file.
        /// </summary>
        public ConfigurationType Type { get; set; }

        /// <summary>
        /// The content of the configuration file.
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// The environment for which the configuration is intended (e.g., Development, Production).
        /// </summary>
        public string Environment { get; set; } = string.Empty;

        /// <summary>
        /// The settings defined in the configuration file.
        /// </summary>
        public Dictionary<string, object> Settings { get; set; } = new();

        /// <summary>
        /// Indicates whether the configuration file is encrypted.
        /// </summary>
        public bool IsEncrypted { get; set; }

        /// <summary>
        /// The date and time when the configuration file was created (UTC).
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
