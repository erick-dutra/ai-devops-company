namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the type of database script.
    /// </summary>
    public enum DatabaseScriptType
    {
        /// <summary>
        /// Script for database schema changes.
        /// </summary>
        Schema,
        /// <summary>
        /// Script for data manipulation or seeding.
        /// </summary>
        Data,
        /// <summary>
        /// Script for database migrations.
        /// </summary>
        Migration,
        /// <summary>
        /// Script for rolling back changes.
        /// </summary>
        Rollback,
        /// <summary>
        /// Script for creating or modifying indexes.
        /// </summary>
        Index,
        /// <summary>
        /// Script for stored procedures.
        /// </summary>
        Procedure,
        /// <summary>
        /// Script for user-defined functions.
        /// </summary>
        Function,
        /// <summary>
        /// Script for database triggers.
        /// </summary>
        Trigger
    }
}
