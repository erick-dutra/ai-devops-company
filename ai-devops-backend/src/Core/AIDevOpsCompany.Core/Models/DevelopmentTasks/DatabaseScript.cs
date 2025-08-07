namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a database script, including its metadata, type, content, affected tables, and rollback information.
    /// </summary>
    public class DatabaseScript
    {
        /// <summary>
        /// The unique identifier for the database script.
        /// </summary>
        public string ScriptId { get; set; } = string.Empty;

        /// <summary>
        /// The name of the database script.
        /// </summary>
        public string ScriptName { get; set; } = string.Empty;

        /// <summary>
        /// The type of the database script.
        /// </summary>
        public DatabaseScriptType ScriptType { get; set; }

        /// <summary>
        /// The content of the database script.
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// The type of database the script is intended for.
        /// </summary>
        public string DatabaseType { get; set; } = string.Empty;

        /// <summary>
        /// The list of tables affected by the script.
        /// </summary>
        public List<string> AffectedTables { get; set; } = new();

        /// <summary>
        /// Indicates whether the script is reversible.
        /// </summary>
        public bool IsReversible { get; set; }

        /// <summary>
        /// The rollback script to reverse the changes, if applicable.
        /// </summary>
        public string RollbackScript { get; set; } = string.Empty;

        /// <summary>
        /// The date and time when the script was created (UTC).
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
