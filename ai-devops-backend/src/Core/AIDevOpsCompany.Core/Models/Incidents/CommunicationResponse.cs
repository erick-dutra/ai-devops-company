namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents a response to an incident communication, including responder, content, timestamp, and type.
    /// </summary>
    public class CommunicationResponse
    {
        /// <summary>
        /// The unique identifier for the response.
        /// </summary>
        public string ResponseId { get; set; } = string.Empty;

        /// <summary>
        /// The ID of the responder.
        /// </summary>
        public string ResponderId { get; set; } = string.Empty;

        /// <summary>
        /// The content of the response.
        /// </summary>
        public string Response { get; set; } = string.Empty;

        /// <summary>
        /// The date and time when the response was received (UTC).
        /// </summary>
        public DateTime ReceivedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The type of the response.
        /// </summary>
        public ResponseType Type { get; set; }
    }
}
