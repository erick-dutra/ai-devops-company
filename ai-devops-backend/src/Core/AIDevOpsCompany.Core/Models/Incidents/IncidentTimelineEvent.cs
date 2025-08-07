namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents an event in the timeline of an incident.
    /// </summary>
    public class IncidentTimelineEvent
    {
        /// <summary>
        /// Gets or sets the unique identifier for the event.
        /// </summary>
        public string EventId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the timestamp of the event.
        /// </summary>
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        public IncidentEventType Type { get; set; }
        /// <summary>
        /// Gets or sets the description of the event.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the identifier of the agent who performed the event.
        /// </summary>
        public string PerformedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets additional data related to the event.
        /// </summary>
        public Dictionary<string, object> EventData { get; set; } = new();
        /// <summary>
        /// Gets or sets a value indicating whether the event was automated.
        /// </summary>
        public bool IsAutomated { get; set; }
    }
}
