namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents the impact of an incident on a component, users, or business.
    /// </summary>
    public class IncidentImpact
    {
        /// <summary>
        /// Gets or sets the unique identifier for the impact.
        /// </summary>
        public string ImpactId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the type of impact.
        /// </summary>
        public ImpactType Type { get; set; }
        /// <summary>
        /// Gets or sets the severity of the impact.
        /// </summary>
        public ImpactSeverity Severity { get; set; }
        /// <summary>
        /// Gets or sets the description of the impact.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the affected component.
        /// </summary>
        public string AffectedComponent { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the number of affected users.
        /// </summary>
        public int AffectedUserCount { get; set; }
        /// <summary>
        /// Gets or sets the business impact value.
        /// </summary>
        public decimal BusinessImpact { get; set; }
        /// <summary>
        /// Gets or sets the duration of the impact.
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Gets or sets the start time of the impact.
        /// </summary>
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the end time of the impact, if ended.
        /// </summary>
        public DateTime? EndedAt { get; set; }
        /// <summary>
        /// Gets or sets additional metrics related to the impact.
        /// </summary>
        public Dictionary<string, object> Metrics { get; set; } = new();
    }
}
