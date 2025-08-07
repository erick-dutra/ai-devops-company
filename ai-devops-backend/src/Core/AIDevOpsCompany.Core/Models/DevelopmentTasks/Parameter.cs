namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a parameter for a function, method, or configuration, including its name, type, default value, and description.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// The name of the parameter.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The data type of the parameter.
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether the parameter is optional.
        /// </summary>
        public bool IsOptional { get; set; }

        /// <summary>
        /// The default value of the parameter, if any.
        /// </summary>
        public string DefaultValue { get; set; } = string.Empty;

        /// <summary>
        /// A description of the parameter's purpose.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
