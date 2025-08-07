namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the status of a performance goal.
    /// </summary>
    public enum GoalStatus
    {
        /// <summary>
        /// The goal is currently active.
        /// </summary>
        Active,
        /// <summary>
        /// The goal has been completed.
        /// </summary>
        Completed,
        /// <summary>
        /// The goal has been cancelled.
        /// </summary>
        Cancelled,
        /// <summary>
        /// The goal is on hold.
        /// </summary>
        OnHold,
        /// <summary>
        /// The goal is overdue.
        /// </summary>
        Overdue
    }
}
