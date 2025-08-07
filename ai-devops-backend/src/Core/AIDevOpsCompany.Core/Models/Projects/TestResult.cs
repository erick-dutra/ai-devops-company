namespace AIDevOpsCompany.Core.Models.Projects
{
    /// <summary>
    /// Specifies the result of a test execution.
    /// </summary>
    public enum TestResult
    {
        /// <summary>Test passed successfully.</summary>
        Passed,
        /// <summary>Test failed.</summary>
        Failed,
        /// <summary>Test was skipped.</summary>
        Skipped,
        /// <summary>An error occurred during test execution.</summary>
        Error
    }
}
