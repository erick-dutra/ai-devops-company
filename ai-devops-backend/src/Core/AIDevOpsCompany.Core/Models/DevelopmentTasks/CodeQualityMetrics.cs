namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents code quality metrics, including maintainability, reliability, security, performance, readability, testability, and code issues.
    /// </summary>
    public class CodeQualityMetrics
    {
        /// <summary>
        /// The maintainability score of the code.
        /// </summary>
        public double Maintainability { get; set; }

        /// <summary>
        /// The reliability score of the code.
        /// </summary>
        public double Reliability { get; set; }

        /// <summary>
        /// The security score of the code.
        /// </summary>
        public double Security { get; set; }

        /// <summary>
        /// The performance score of the code.
        /// </summary>
        public double Performance { get; set; }

        /// <summary>
        /// The readability score of the code.
        /// </summary>
        public double Readability { get; set; }

        /// <summary>
        /// The testability score of the code.
        /// </summary>
        public double Testability { get; set; }

        /// <summary>
        /// The estimated technical debt in minutes.
        /// </summary>
        public int TechnicalDebtMinutes { get; set; }

        /// <summary>
        /// The number of code smells detected.
        /// </summary>
        public int CodeSmells { get; set; }

        /// <summary>
        /// The number of bugs detected in the code.
        /// </summary>
        public int Bugs { get; set; }

        /// <summary>
        /// The number of security vulnerabilities detected.
        /// </summary>
        public int Vulnerabilities { get; set; }
    }
}
