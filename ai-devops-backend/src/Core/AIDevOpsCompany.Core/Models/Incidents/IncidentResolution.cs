namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents the resolution details of an incident, including actions, root cause, and verification.
    /// </summary>
    public class IncidentResolution
    {
        /// <summary>
        /// Unique identifier for the incident resolution.
        /// </summary>
        public string ResolutionId { get; set; } = string.Empty;
        /// <summary>
        /// Type of the resolution applied.
        /// </summary>
        public ResolutionType Type { get; set; }
        /// <summary>
        /// Short summary of the resolution.
        /// </summary>
        public string Summary { get; set; } = string.Empty;
        /// <summary>
        /// Detailed description of the resolution.
        /// </summary>
        public string DetailedDescription { get; set; } = string.Empty;
        /// <summary>
        /// Root cause of the incident.
        /// </summary>
        public string RootCause { get; set; } = string.Empty;
        /// <summary>
        /// List of contributing factors to the incident.
        /// </summary>
        public List<string> ContributingFactors { get; set; } = new();
        /// <summary>
        /// List of actions taken to resolve the incident.
        /// </summary>
        public List<ResolutionAction> Actions { get; set; } = new();
        /// <summary>
        /// Indicates if the resolution is permanent.
        /// </summary>
        public bool IsPermanent { get; set; }
        /// <summary>
        /// Temporary workaround applied, if any.
        /// </summary>
        public string TemporaryWorkaround { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the incident was resolved.
        /// </summary>
        public DateTime ResolvedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Identifier of the agent who resolved the incident.
        /// </summary>
        public string ResolvedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// List of steps used to verify the resolution.
        /// </summary>
        public List<string> VerificationSteps { get; set; } = new();
        /// <summary>
        /// Indicates if the resolution was verified.
        /// </summary>
        public bool Verified { get; set; }
        /// <summary>
        /// Date and time when the resolution was verified.
        /// </summary>
        public DateTime? VerifiedAt { get; set; }
        /// <summary>
        /// Identifier of the agent who verified the resolution.
        /// </summary>
        public string VerifiedByAgentId { get; set; } = string.Empty;
    }
}
