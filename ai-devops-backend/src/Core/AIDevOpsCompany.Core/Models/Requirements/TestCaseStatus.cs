namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Specifies the status of a test case.
    /// </summary>
    public enum TestCaseStatus
    {
        /// <summary>Test case is in draft state.</summary>
        Draft,
        /// <summary>Test case is ready for execution.</summary>
        Ready,
        /// <summary>Test case is currently in progress.</summary>
        InProgress,
        /// <summary>Test case has been completed.</summary>
        Completed,
        /// <summary>Test case is blocked.</summary>
        Blocked
    }
}
