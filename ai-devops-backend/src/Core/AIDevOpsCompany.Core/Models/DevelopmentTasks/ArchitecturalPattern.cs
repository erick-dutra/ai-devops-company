namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents an architectural pattern, including its name, description, components, relationships, and any pattern-specific data.
    /// </summary>
    public class ArchitecturalPattern
    {
        /// <summary>
        /// The name of the architectural pattern.
        /// </summary>
        public string PatternName { get; set; } = string.Empty;

        /// <summary>
        /// A description of the architectural pattern.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The list of components involved in the architectural pattern.
        /// </summary>
        public List<string> Components { get; set; } = new();

        /// <summary>
        /// The relationships between components in the architectural pattern.
        /// </summary>
        public List<ComponentRelationship> Relationships { get; set; } = new();

        /// <summary>
        /// Additional data specific to the architectural pattern.
        /// </summary>
        public Dictionary<string, object> PatternSpecificData { get; set; } = new();
    }
}
