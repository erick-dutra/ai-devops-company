namespace AIDevOpsCompany.Core.Models.Projects
{
    /// <summary>
    /// Represents various metrics associated with a project.
    /// </summary>
    public class ProjectMetrics
    {
        /// <summary>
        /// The total number of lines of code in the project.
        /// </summary>
        public int TotalLinesOfCode { get; set; }
        
        /// <summary>
        /// The total number of test cases in the project.
        /// </summary>
        public int TotalTestCases { get; set; }
        
        /// <summary>
        /// The percentage of code covered by tests (0-100).
        /// </summary>
        public double CodeCoverage { get; set; }
        
        /// <summary>
        /// The number of bugs found in the project.
        /// </summary>
        public int BugsFound { get; set; }
        
        /// <summary>
        /// The number of bugs fixed in the project.
        /// </summary>
        public int BugsFixed { get; set; }
        
        /// <summary>
        /// The total time spent on development.
        /// </summary>
        public TimeSpan TotalDevelopmentTime { get; set; }
        
        /// <summary>
        /// The estimated cost of the project.
        /// </summary>
        public decimal EstimatedCost { get; set; }
        
        /// <summary>
        /// The actual cost of the project.
        /// </summary>
        public decimal ActualCost { get; set; }
        
        /// <summary>
        /// Custom metrics for the project.
        /// </summary>
        public Dictionary<string, object> CustomMetrics { get; set; } = new();
    }
}
