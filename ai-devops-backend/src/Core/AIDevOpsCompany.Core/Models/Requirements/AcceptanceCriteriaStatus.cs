namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Specifies the status of an acceptance criteria.
    /// </summary>
    public enum AcceptanceCriteriaStatus
    {
        /// <summary>Acceptance criteria is pending.</summary>
        Pending,
        /// <summary>Acceptance criteria is in progress.</summary>
        InProgress,
        /// <summary>Acceptance criteria is completed.</summary>
        Completed,
        /// <summary>Acceptance criteria has failed.</summary>
        Failed
    }
}
