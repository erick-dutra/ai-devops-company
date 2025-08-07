namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents a gap in the process identified during a post-incident review.
    /// </summary>
    public class ProcessGap
    {
        /// <summary>
        /// Gets or sets the unique identifier for the process gap.
        /// </summary>
        public string GapId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description of the process gap.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the type of the process gap.
        /// </summary>
        public ProcessGapType Type { get; set; }
        /// <summary>
        /// Gets or sets the severity of the process gap.
        /// </summary>
        public ProcessGapSeverity Severity { get; set; }
        /// <summary>
        /// Gets or sets the impact of the process gap.
        /// </summary>
        public string Impact { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the recommended action to address the gap.
        /// </summary>
        public string RecommendedAction { get; set; } = string.Empty;
    }
}
