namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents the timeline of an incident, including key timestamps and events.
    /// </summary>
    public class IncidentTimeline
    {
        /// <summary>
        /// Gets or sets the date and time when the incident was detected.
        /// </summary>
        public DateTime DetectedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the date and time when the incident was acknowledged.
        /// </summary>
        public DateTime? AcknowledgedAt { get; set; }
        /// <summary>
        /// Gets or sets the date and time when investigation started.
        /// </summary>
        public DateTime? InvestigationStartedAt { get; set; }
        /// <summary>
        /// Gets or sets the date and time when mitigation started.
        /// </summary>
        public DateTime? MitigationStartedAt { get; set; }
        /// <summary>
        /// Gets or sets the date and time when mitigation was completed.
        /// </summary>
        public DateTime? MitigatedAt { get; set; }
        /// <summary>
        /// Gets or sets the date and time when the incident was resolved.
        /// </summary>
        public DateTime? ResolvedAt { get; set; }
        /// <summary>
        /// Gets or sets the date and time when the incident was closed.
        /// </summary>
        public DateTime? ClosedAt { get; set; }
        /// <summary>
        /// Gets or sets the time taken to acknowledge the incident.
        /// </summary>
        public TimeSpan TimeToAcknowledge { get; set; }
        /// <summary>
        /// Gets or sets the time taken to mitigate the incident.
        /// </summary>
        public TimeSpan TimeToMitigate { get; set; }
        /// <summary>
        /// Gets or sets the time taken to resolve the incident.
        /// </summary>
        public TimeSpan TimeToResolve { get; set; }
        /// <summary>
        /// Gets or sets the list of timeline events for the incident.
        /// </summary>
        public List<IncidentTimelineEvent> Events { get; set; } = new();
    }
}
