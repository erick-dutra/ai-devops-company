namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the severity levels for accessibility issues based on their impact on users with disabilities.
    /// </summary>
    public enum AccessibilityIssueSeverity
    {
        /// <summary>
        /// Issues that completely prevent users with disabilities from using the application.
        /// </summary>
        Critical,
        
        /// <summary>
        /// Issues that significantly impact users with disabilities but don't completely prevent use.
        /// </summary>
        Major,
        
        /// <summary>
        /// Issues that cause some inconvenience for users with disabilities.
        /// </summary>
        Minor,
        
        /// <summary>
        /// Issues that have minimal impact or are advisory in nature.
        /// </summary>
        Info
    }
}
