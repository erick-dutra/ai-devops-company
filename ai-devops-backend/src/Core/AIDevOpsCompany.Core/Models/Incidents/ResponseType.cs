namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the type of response in incident communication.
    /// </summary>
    public enum ResponseType
    {
        /// <summary>
        /// Acknowledgment of receipt or awareness.
        /// </summary>
        Acknowledgment,
        /// <summary>
        /// A question or request for clarification.
        /// </summary>
        Question,
        /// <summary>
        /// An update on the incident status or progress.
        /// </summary>
        Update,
        /// <summary>
        /// Escalation to a higher authority or team.
        /// </summary>
        Escalation,
        /// <summary>
        /// Final resolution or closure of the incident.
        /// </summary>
        Resolution
    }
}
