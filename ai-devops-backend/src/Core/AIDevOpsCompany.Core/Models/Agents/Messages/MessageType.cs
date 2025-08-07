namespace AIDevOpsCompany.Core.Models.Agents.Messages
{
    /// <summary>
    /// Types of messages exchanged between agents.
    /// </summary>
    public enum MessageType
    {
        /// <summary>Indicates a task was completed.</summary>
        TaskCompleted,
        /// <summary>Indicates a task failed.</summary>
        TaskFailed,
        /// <summary>Status update message.</summary>
        StatusUpdate,
        /// <summary>Error report message.</summary>
        ErrorReport
    }
}
