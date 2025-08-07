namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a relationship between two components in an architectural pattern.
    /// </summary>
    public class ComponentRelationship
    {
        /// <summary>
        /// The name of the source component in the relationship.
        /// </summary>
        public string FromComponent { get; set; } = string.Empty;

        /// <summary>
        /// The name of the target component in the relationship.
        /// </summary>
        public string ToComponent { get; set; } = string.Empty;

        /// <summary>
        /// The type of relationship between the components.
        /// </summary>
        public RelationshipType RelationshipType { get; set; }

        /// <summary>
        /// A description of the relationship.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
