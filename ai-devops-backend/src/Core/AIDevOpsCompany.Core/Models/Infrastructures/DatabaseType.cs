namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the type of database used in the infrastructure.
    /// </summary>
    public enum DatabaseType
    {
        /// <summary>
        /// MySQL database.
        /// </summary>
        MySQL,
        /// <summary>
        /// PostgreSQL database.
        /// </summary>
        PostgreSQL,
        /// <summary>
        /// MongoDB database.
        /// </summary>
        MongoDB,
        /// <summary>
        /// Redis database.
        /// </summary>
        Redis,
        /// <summary>
        /// Elasticsearch database.
        /// </summary>
        Elasticsearch,
        /// <summary>
        /// DynamoDB database.
        /// </summary>
        DynamoDB,
        /// <summary>
        /// CosmosDB database.
        /// </summary>
        CosmosDB,
        /// <summary>
        /// SQL Server database.
        /// </summary>
        SQLServer,
        /// <summary>
        /// Oracle database.
        /// </summary>
        Oracle
    }
}
