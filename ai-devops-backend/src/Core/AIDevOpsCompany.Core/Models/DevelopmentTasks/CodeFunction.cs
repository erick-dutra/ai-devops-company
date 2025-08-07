namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a function or method in code, including its name, description, parameters, return type, complexity, and test information.
    /// </summary>
    public class CodeFunction
    {
        /// <summary>
        /// The name of the function.
        /// </summary>
        public string FunctionName { get; set; } = string.Empty;

        /// <summary>
        /// A description of the function's purpose.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The list of parameters for the function.
        /// </summary>
        public List<Parameter> Parameters { get; set; } = new();

        /// <summary>
        /// The return type of the function.
        /// </summary>
        public string ReturnType { get; set; } = string.Empty;

        /// <summary>
        /// The cyclomatic complexity of the function.
        /// </summary>
        public int CyclomaticComplexity { get; set; }

        /// <summary>
        /// The number of lines of code in the function.
        /// </summary>
        public int LinesOfCode { get; set; }

        /// <summary>
        /// Indicates whether the function has associated tests.
        /// </summary>
        public bool HasTests { get; set; }

        /// <summary>
        /// The list of test cases for the function.
        /// </summary>
        public List<string> TestCases { get; set; } = new();
    }
}
