namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the status of an action item.
    /// </summary>
    public enum ActionItemStatus
    {
        /// <summary>The action item is open and not yet started.</summary>
        Open,
        /// <summary>The action item is in progress.</summary>
        InProgress,
        /// <summary>The action item is completed.</summary>
        Completed,
        /// <summary>The action item is cancelled.</summary>
        Cancelled,
        /// <summary>The action item is blocked.</summary>
        Blocked
    }
}
