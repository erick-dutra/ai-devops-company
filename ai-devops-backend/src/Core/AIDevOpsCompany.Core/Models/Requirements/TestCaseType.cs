namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Specifies the type of a test case.
    /// </summary>
    public enum TestCaseType
    {
        /// <summary>Functional test case.</summary>
        Functional,
        /// <summary>Non-functional test case.</summary>
        NonFunctional,
        /// <summary>Integration test case.</summary>
        Integration,
        /// <summary>Regression test case.</summary>
        Regression,
        /// <summary>Acceptance test case.</summary>
        Acceptance
    }
}
