namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the status of a performance issue.
    /// </summary>
    public enum PerformanceIssueStatus
    {
        /// <summary>
        /// The issue is open and requires attention.
        /// </summary>
        Open,
        /// <summary>
        /// The issue is currently being addressed.
        /// </summary>
        InProgress,
        /// <summary>
        /// The issue has been resolved.
        /// </summary>
        Resolved,
        /// <summary>
        /// The issue is closed and no further action is required.
        /// </summary>
        Closed,
        /// <summary>
        /// The issue has been cancelled.
        /// </summary>
        Cancelled
    }
}
