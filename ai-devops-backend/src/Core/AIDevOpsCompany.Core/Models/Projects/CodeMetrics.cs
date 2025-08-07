namespace AIDevOpsCompany.Core.Models.Projects
{
    /// <summary>
    /// Represents metrics for code quality and complexity.
    /// </summary>
    public class CodeMetrics
    {
        /// <summary>
        /// Total number of lines of code.
        /// </summary>
        public int LinesOfCode { get; set; }
        
        /// <summary>
        /// Cyclomatic complexity measure of the code.
        /// </summary>
        public int CyclomaticComplexity { get; set; }
        
        /// <summary>
        /// Percentage of code covered by tests (0-100).
        /// </summary>
        public double CodeCoverage { get; set; }
        
        /// <summary>
        /// Total number of classes in the codebase.
        /// </summary>
        public int NumberOfClasses { get; set; }
        
        /// <summary>
        /// Total number of methods in the codebase.
        /// </summary>
        public int NumberOfMethods { get; set; }
        
        /// <summary>
        /// Total number of tests in the codebase.
        /// </summary>
        public int NumberOfTests { get; set; }
        
        /// <summary>
        /// List of technical debt items in the code.
        /// </summary>
        public List<string> TechnicalDebt { get; set; } = new();
        
        /// <summary>
        /// Breakdown of code by programming language.
        /// </summary>
        public Dictionary<string, int> LanguageBreakdown { get; set; } = new();
    }
}
