namespace AIDevOpsCompany.Core.Models.Projects
{
    /// <summary>
    /// Specifies the status of a project milestone.
    /// </summary>
    public enum MilestoneStatus
    {
        /// <summary>Milestone is pending and not yet started.</summary>
        Pending,
        /// <summary>Milestone is currently in progress.</summary>
        InProgress,
        /// <summary>Milestone has been completed.</summary>
        Completed,
        /// <summary>Milestone is blocked.</summary>
        Blocked,
        /// <summary>Milestone has been cancelled.</summary>
        Cancelled
    }
}
