namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a code class, including its name, description, interfaces, base class, properties, methods, type, and test status.
    /// </summary>
    public class CodeClass
    {
        /// <summary>
        /// The name of the class.
        /// </summary>
        public string ClassName { get; set; } = string.Empty;

        /// <summary>
        /// A description of the class.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The list of interfaces implemented by the class.
        /// </summary>
        public List<string> Interfaces { get; set; } = new();

        /// <summary>
        /// The name of the base class, if any.
        /// </summary>
        public string BaseClass { get; set; } = string.Empty;

        /// <summary>
        /// The list of properties defined in the class.
        /// </summary>
        public List<Property> Properties { get; set; } = new();

        /// <summary>
        /// The list of methods defined in the class.
        /// </summary>
        public List<CodeFunction> Methods { get; set; } = new();

        /// <summary>
        /// The type of the class (e.g., entity, service, controller).
        /// </summary>
        public ClassType ClassType { get; set; }

        /// <summary>
        /// Indicates whether the class has associated tests.
        /// </summary>
        public bool HasTests { get; set; }
    }
}
