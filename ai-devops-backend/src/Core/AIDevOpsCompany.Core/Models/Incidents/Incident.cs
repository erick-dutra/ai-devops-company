namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents an incident that occurred within a project or system.
    /// </summary>
    public class Incident
    {
        /// <summary>
        /// Unique identifier for the incident.
        /// </summary>
        public string IncidentId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the related project.
        /// </summary>
        public string ProjectId { get; set; } = string.Empty;
        /// <summary>
        /// Title of the incident.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Description of the incident.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Severity of the incident.
        /// </summary>
        public IncidentSeverity Severity { get; set; }
        /// <summary>
        /// Priority of the incident.
        /// </summary>
        public IncidentPriority Priority { get; set; }
        /// <summary>
        /// Current status of the incident.
        /// </summary>
        public IncidentStatus Status { get; set; } = IncidentStatus.Open;
        /// <summary>
        /// Category of the incident.
        /// </summary>
        public IncidentCategory Category { get; set; }
        /// <summary>
        /// Source of the incident.
        /// </summary>
        public IncidentSource Source { get; set; } = new();
        /// <summary>
        /// List of impacts caused by the incident.
        /// </summary>
        public List<IncidentImpact> Impacts { get; set; } = new();
        /// <summary>
        /// Timeline of the incident events.
        /// </summary>
        public IncidentTimeline Timeline { get; set; } = new();
        /// <summary>
        /// List of actions taken in response to the incident.
        /// </summary>
        public List<IncidentAction> Actions { get; set; } = new();
        /// <summary>
        /// List of communications related to the incident.
        /// </summary>
        public List<IncidentCommunication> Communications { get; set; } = new();
        /// <summary>
        /// Resolution details for the incident.
        /// </summary>
        public IncidentResolution Resolution { get; set; } = new();
        /// <summary>
        /// Post-incident review details.
        /// </summary>
        public PostIncidentReview PostIncidentReview { get; set; } = new();
        /// <summary>
        /// Identifier of the agent assigned to the incident.
        /// </summary>
        public string AssignedToAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the agent who reported the incident.
        /// </summary>
        public string ReportedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the incident was reported.
        /// </summary>
        public DateTime ReportedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date and time when the incident was resolved.
        /// </summary>
        public DateTime? ResolvedAt { get; set; }
        /// <summary>
        /// Date and time when the incident was closed.
        /// </summary>
        public DateTime? ClosedAt { get; set; }
        /// <summary>
        /// List of affected services.
        /// </summary>
        public List<string> AffectedServices { get; set; } = new();
        /// <summary>
        /// List of affected users.
        /// </summary>
        public List<string> AffectedUsers { get; set; } = new();
        /// <summary>
        /// Custom fields for extensibility.
        /// </summary>
        public Dictionary<string, object> CustomFields { get; set; } = new();
    }
}
