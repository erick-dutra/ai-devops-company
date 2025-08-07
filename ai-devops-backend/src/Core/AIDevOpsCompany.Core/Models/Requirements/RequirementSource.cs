namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Represents the source of a requirement, such as a client or stakeholder.
    /// </summary>
    public class RequirementSource
    {
        /// <summary>
        /// Gets or sets the type of the source (e.g., Client, Stakeholder, Analysis).
        /// </summary>
        public string SourceType { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the unique identifier of the source.
        /// </summary>
        public string SourceId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the source.
        /// </summary>
        public string SourceName { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the original text provided by the source.
        /// </summary>
        public string OriginalText { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the date and time when the requirement was provided.
        /// </summary>
        public DateTime ProvidedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets additional metadata related to the source.
        /// </summary>
        public Dictionary<string, object> SourceMetadata { get; set; } = new();
    }
}
