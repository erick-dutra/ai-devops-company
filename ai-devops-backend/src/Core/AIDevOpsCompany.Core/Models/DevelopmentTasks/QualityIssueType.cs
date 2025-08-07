namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the type of quality issue found in code.
    /// </summary>
    public enum QualityIssueType
    {
        /// <summary>
        /// Bug in the code.
        /// </summary>
        Bug,
        /// <summary>
        /// Security vulnerability.
        /// </summary>
        Vulnerability,
        /// <summary>
        /// Code smell or maintainability issue.
        /// </summary>
        CodeSmell,
        /// <summary>
        /// Performance issue.
        /// </summary>
        Performance,
        /// <summary>
        /// Maintainability issue.
        /// </summary>
        Maintainability,
        /// <summary>
        /// Reliability issue.
        /// </summary>
        Reliability,
        /// <summary>
        /// Security issue.
        /// </summary>
        Security
    }
}
