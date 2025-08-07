namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents a reliability incident affecting an agent's performance.
    /// </summary>
    public class ReliabilityIncident
    {
        /// <summary>
        /// Unique identifier for the reliability incident.
        /// </summary>
        public string IncidentId { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the incident occurred.
        /// </summary>
        public DateTime OccurredAt { get; set; }
        /// <summary>
        /// Duration of the incident.
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Severity of the reliability incident.
        /// </summary>
        public ReliabilityIncidentSeverity Severity { get; set; }
        /// <summary>
        /// Description of the incident.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Root cause of the incident.
        /// </summary>
        public string RootCause { get; set; } = string.Empty;
        /// <summary>
        /// Resolution applied to the incident.
        /// </summary>
        public string Resolution { get; set; } = string.Empty;
        /// <summary>
        /// Indicates if prevention measures were implemented after the incident.
        /// </summary>
        public bool PreventionMeasuresImplemented { get; set; }
    }
}
