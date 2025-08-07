namespace AIDevOpsCompany.Core.Models.Commons
{
    /// <summary>
    /// Status values for a task.
    /// </summary>
    public enum TaskStatus
    {
        /// <summary>Task is pending and not yet started.</summary>
        Pending,
        /// <summary>Task is currently in progress.</summary>
        InProgress,
        /// <summary>Task has been completed successfully.</summary>
        Completed,
        /// <summary>Task has failed.</summary>
        Failed,
        /// <summary>Task was cancelled before completion.</summary>
        Cancelled
    }
}
