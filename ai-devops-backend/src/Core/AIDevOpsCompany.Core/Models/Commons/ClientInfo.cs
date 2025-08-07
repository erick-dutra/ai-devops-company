namespace AIDevOpsCompany.Core.Models.Commons
{
    /// <summary>
    /// Represents client information for a project or invoice.
    /// </summary>
    public class ClientInfo
    {
        /// <summary>
        /// Unique identifier for the client.
        /// </summary>
        public string ClientId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the client.
        /// </summary>
        public string ClientName { get; set; } = string.Empty;
        /// <summary>
        /// Contact email address for the client.
        /// </summary>
        public string ContactEmail { get; set; } = string.Empty;
        /// <summary>
        /// Contact phone number for the client.
        /// </summary>
        public string ContactPhone { get; set; } = string.Empty;
        /// <summary>
        /// Company name of the client.
        /// </summary>
        public string Company { get; set; } = string.Empty;
        /// <summary>
        /// Additional information about the client.
        /// </summary>
        public Dictionary<string, object> AdditionalInfo { get; set; } = new();
    }
}
