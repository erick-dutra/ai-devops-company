namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the configuration settings for a database in the infrastructure.
    /// </summary>
    public class DatabaseConfiguration
    {
        /// <summary>
        /// Type of database being used.
        /// </summary>
        public DatabaseType Type { get; set; }
        /// <summary>
        /// Database engine (e.g., MySQL, PostgreSQL).
        /// </summary>
        public string Engine { get; set; } = string.Empty;
        /// <summary>
        /// Version of the database engine.
        /// </summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>
        /// Instance class or size for the database.
        /// </summary>
        public string InstanceClass { get; set; } = string.Empty;
        /// <summary>
        /// Storage size in gigabytes.
        /// </summary>
        public int StorageGB { get; set; }
        /// <summary>
        /// Indicates if Multi-AZ deployment is enabled.
        /// </summary>
        public bool MultiAZ { get; set; }
        /// <summary>
        /// Indicates if backups are enabled.
        /// </summary>
        public bool BackupEnabled { get; set; }
        /// <summary>
        /// Number of days to retain backups.
        /// </summary>
        public int BackupRetentionDays { get; set; }
        /// <summary>
        /// Preferred backup window.
        /// </summary>
        public string BackupWindow { get; set; } = string.Empty;
        /// <summary>
        /// Preferred maintenance window.
        /// </summary>
        public string MaintenanceWindow { get; set; } = string.Empty;
        /// <summary>
        /// Indicates if encryption is enabled for the database.
        /// </summary>
        public bool EncryptionEnabled { get; set; }
        /// <summary>
        /// List of users with access to the database.
        /// </summary>
        public List<DatabaseUser> Users { get; set; } = new();
    }
}
