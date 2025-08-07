namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the configuration of a resource, including CPU, memory, storage, and network settings.
    /// </summary>
    public class ResourceConfiguration
    {
        /// <summary>
        /// Number of CPU cores assigned to the resource.
        /// </summary>
        public int CpuCores { get; set; }
        /// <summary>
        /// Amount of memory in GB assigned to the resource.
        /// </summary>
        public int MemoryGB { get; set; }
        /// <summary>
        /// Amount of storage in GB assigned to the resource.
        /// </summary>
        public int StorageGB { get; set; }
        /// <summary>
        /// Type of storage used (e.g., SSD, HDD).
        /// </summary>
        public string StorageType { get; set; } = string.Empty;
        /// <summary>
        /// List of network configurations for the resource.
        /// </summary>
        public List<NetworkConfiguration> Networks { get; set; } = new();
        /// <summary>
        /// List of security groups associated with the resource.
        /// </summary>
        public List<SecurityGroup> SecurityGroups { get; set; } = new();
        /// <summary>
        /// Environment variables for the resource.
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables { get; set; } = new();
        /// <summary>
        /// List of installed software on the resource.
        /// </summary>
        public List<string> InstalledSoftware { get; set; } = new();
        /// <summary>
        /// Operating system of the resource.
        /// </summary>
        public string OperatingSystem { get; set; } = string.Empty;
        /// <summary>
        /// Custom settings for the resource.
        /// </summary>
        public Dictionary<string, object> CustomSettings { get; set; } = new();
    }
}
