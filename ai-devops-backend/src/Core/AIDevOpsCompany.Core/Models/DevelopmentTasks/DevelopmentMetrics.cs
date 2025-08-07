namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents development metrics for a software project or task, including effort, code statistics, coverage, and custom metrics.
    /// </summary>
    public class DevelopmentMetrics
    {
        /// <summary>
        /// The estimated effort required for the task or project.
        /// </summary>
        public TimeSpan EstimatedEffort { get; set; }

        /// <summary>
        /// The actual effort spent on the task or project.
        /// </summary>
        public TimeSpan ActualEffort { get; set; }

        /// <summary>
        /// The total number of lines of code.
        /// </summary>
        public int TotalLinesOfCode { get; set; }

        /// <summary>
        /// The total number of files involved.
        /// </summary>
        public int NumberOfFiles { get; set; }

        /// <summary>
        /// The total number of classes.
        /// </summary>
        public int NumberOfClasses { get; set; }

        /// <summary>
        /// The total number of methods.
        /// </summary>
        public int NumberOfMethods { get; set; }

        /// <summary>
        /// The average cyclomatic complexity of the codebase.
        /// </summary>
        public double AverageCyclomaticComplexity { get; set; }

        /// <summary>
        /// The total number of test cases.
        /// </summary>
        public int NumberOfTestCases { get; set; }

        /// <summary>
        /// The code coverage percentage.
        /// </summary>
        public double CodeCoverage { get; set; }

        /// <summary>
        /// The total number of dependencies.
        /// </summary>
        public int NumberOfDependencies { get; set; }

        /// <summary>
        /// A breakdown of lines of code by programming language.
        /// </summary>
        public Dictionary<string, int> LanguageBreakdown { get; set; } = new();

        /// <summary>
        /// Custom metrics for the development task or project.
        /// </summary>
        public Dictionary<string, object> CustomMetrics { get; set; } = new();
    }
}
