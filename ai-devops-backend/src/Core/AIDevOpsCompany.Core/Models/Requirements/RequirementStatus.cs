namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Specifies the status of a requirement.
    /// </summary>
    public enum RequirementStatus
    {
        /// <summary>Requirement is in draft state.</summary>
        Draft,
        /// <summary>Requirement is under review.</summary>
        UnderReview,
        /// <summary>Requirement is approved.</summary>
        Approved,
        /// <summary>Requirement is in development.</summary>
        InDevelopment,
        /// <summary>Requirement is in testing.</summary>
        InTesting,
        /// <summary>Requirement is completed.</summary>
        Completed,
        /// <summary>Requirement is rejected.</summary>
        Rejected,
        /// <summary>Requirement is deferred.</summary>
        Deferred
    }
}
