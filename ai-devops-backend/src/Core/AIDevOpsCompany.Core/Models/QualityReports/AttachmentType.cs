namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the types of attachments that can be added to bug reports.
    /// </summary>
    public enum AttachmentType
    {
        /// <summary>
        /// Image capture of the application screen showing the bug.
        /// </summary>
        Screenshot,
        
        /// <summary>
        /// Video recording of the bug occurrence or reproduction steps.
        /// </summary>
        Video,
        
        /// <summary>
        /// System or application log files relevant to the bug.
        /// </summary>
        Log,
        
        /// <summary>
        /// Documentation or text-based file providing additional information.
        /// </summary>
        Document,
        
        /// <summary>
        /// Source code snippet or file related to the bug.
        /// </summary>
        Code,
        
        /// <summary>
        /// Any other type of attachment not covered by the defined categories.
        /// </summary>
        Other
    }
}
