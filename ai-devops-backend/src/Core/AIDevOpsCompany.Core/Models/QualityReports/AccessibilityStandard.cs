namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents an accessibility standard and its compliance level.
    /// </summary>
    public class AccessibilityStandard
    {
        /// <summary>
        /// Gets or sets the name of the accessibility standard.
        /// </summary>
        public string StandardName { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the version of the standard.
        /// </summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the compliance level for the standard.
        /// </summary>
        public double ComplianceLevel { get; set; }
    }
}
