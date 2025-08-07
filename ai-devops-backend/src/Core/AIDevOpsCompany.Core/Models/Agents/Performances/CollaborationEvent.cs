namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents a collaboration event involving agents, including type, participants, and outcome.
    /// </summary>
    public class CollaborationEvent
    {
        /// <summary>
        /// Gets or sets the unique identifier for the event.
        /// </summary>
        public string EventId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the collaboration event.
        /// </summary>
        public CollaborationEventType Type { get; set; }

        /// <summary>
        /// Gets or sets the description of the event.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of participant agent IDs.
        /// </summary>
        public List<string> ParticipantAgentIds { get; set; } = new();

        /// <summary>
        /// Gets or sets the date and time when the event occurred.
        /// </summary>
        public DateTime OccurredAt { get; set; }

        /// <summary>
        /// Gets or sets the outcome of the collaboration event.
        /// </summary>
        public CollaborationEventOutcome Outcome { get; set; }

        /// <summary>
        /// Gets or sets additional notes about the event.
        /// </summary>
        public string Notes { get; set; } = string.Empty;
    }
}
