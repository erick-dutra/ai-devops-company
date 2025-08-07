namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the type of relationship between components or classes.
    /// </summary>
    public enum RelationshipType
    {
        /// <summary>
        /// Indicates a dependency relationship.
        /// </summary>
        DependsOn,
        /// <summary>
        /// Indicates a usage relationship.
        /// </summary>
        Uses,
        /// <summary>
        /// Indicates an implementation relationship.
        /// </summary>
        Implements,
        /// <summary>
        /// Indicates an extension relationship.
        /// </summary>
        Extends,
        /// <summary>
        /// Indicates an aggregation relationship.
        /// </summary>
        Aggregates,
        /// <summary>
        /// Indicates a composition relationship.
        /// </summary>
        Composes
    }
}
