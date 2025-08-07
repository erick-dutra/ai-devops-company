namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a property of a class, including its name, type, accessors, and description.
    /// </summary>
    public class Property
    {
        /// <summary>
        /// The name of the property.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The data type of the property.
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether the property has a getter.
        /// </summary>
        public bool HasGetter { get; set; }

        /// <summary>
        /// Indicates whether the property has a setter.
        /// </summary>
        public bool HasSetter { get; set; }

        /// <summary>
        /// A description of the property.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
