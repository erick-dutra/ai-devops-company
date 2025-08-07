namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents an event related to infrastructure, such as incidents, changes, or alerts.
    /// </summary>
    public class InfrastructureEvent
    {
        /// <summary>
        /// Unique identifier for the event.
        /// </summary>
        public string EventId { get; set; } = string.Empty;
        /// <summary>
        /// Type of the infrastructure event.
        /// </summary>
        public InfrastructureEventType Type { get; set; }
        /// <summary>
        /// Description of the event.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the related resource.
        /// </summary>
        public string ResourceId { get; set; } = string.Empty;
        /// <summary>
        /// Severity of the event.
        /// </summary>
        public InfrastructureEventSeverity Severity { get; set; }
        /// <summary>
        /// Timestamp when the event occurred.
        /// </summary>
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Agent ID that triggered the event.
        /// </summary>
        public string TriggeredByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Additional event data.
        /// </summary>
        public Dictionary<string, object> EventData { get; set; } = new();
        /// <summary>
        /// Indicates if the event has been resolved.
        /// </summary>
        public bool Resolved { get; set; }
        /// <summary>
        /// Timestamp when the event was resolved, if applicable.
        /// </summary>
        public DateTime? ResolvedAt { get; set; }
    }
}
