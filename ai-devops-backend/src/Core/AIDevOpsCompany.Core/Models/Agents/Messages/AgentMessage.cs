namespace AIDevOpsCompany.Core.Models.Agents.Messages
{
    /// <summary>
    /// Represents a message exchanged between agents.
    /// </summary>
    public class AgentMessage
    {
        /// <summary>
        /// Unique identifier for the message.
        /// </summary>
        public string MessageId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the sending agent.
        /// </summary>
        public string FromAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the receiving agent.
        /// </summary>
        public string ToAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Type of the message.
        /// </summary>
        public MessageType MessageType { get; set; }
        /// <summary>
        /// Content of the message.
        /// </summary>
        public string Content { get; set; } = string.Empty;
        /// <summary>
        /// Additional data associated with the message.
        /// </summary>
        public Dictionary<string, object> Data { get; set; } = new();
        /// <summary>
        /// Timestamp of when the message was created.
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}

