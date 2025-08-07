namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the configuration settings for infrastructure backups.
    /// </summary>
    public class BackupConfiguration
    {
        /// <summary>
        /// Indicates whether backups are enabled.
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// Frequency of the backups.
        /// </summary>
        public BackupFrequency Frequency { get; set; }
        /// <summary>
        /// Number of days to retain backups.
        /// </summary>
        public int RetentionDays { get; set; }
        /// <summary>
        /// List of backup targets (e.g., databases, file systems).
        /// </summary>
        public List<string> BackupTargets { get; set; } = new();
        /// <summary>
        /// Indicates if cross-region replication is enabled.
        /// </summary>
        public bool CrossRegionReplication { get; set; }
        /// <summary>
        /// The region to which backups are replicated.
        /// </summary>
        public string ReplicationRegion { get; set; } = string.Empty;
        /// <summary>
        /// Indicates if encryption is enabled for backups.
        /// </summary>
        public bool EncryptionEnabled { get; set; }
        /// <summary>
        /// Preferred backup window (e.g., time of day).
        /// </summary>
        public string BackupWindow { get; set; } = string.Empty;
    }
}
