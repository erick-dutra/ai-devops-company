namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the frequency at which backups are performed.
    /// </summary>
    public enum BackupFrequency
    {
        /// <summary>
        /// Backups are performed hourly.
        /// </summary>
        Hourly,
        /// <summary>
        /// Backups are performed daily.
        /// </summary>
        Daily,
        /// <summary>
        /// Backups are performed weekly.
        /// </summary>
        Weekly,
        /// <summary>
        /// Backups are performed monthly.
        /// </summary>
        Monthly
    }
}
