namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the possible states of a quality report within its lifecycle.
    /// </summary>
    public enum QualityReportStatus
    {
        /// <summary>
        /// Quality report is created but waiting to start execution.
        /// </summary>
        Pending,
        
        /// <summary>
        /// Quality report is currently being executed.
        /// </summary>
        InProgress,
        
        /// <summary>
        /// Quality report has successfully completed execution.
        /// </summary>
        Completed,
        
        /// <summary>
        /// Quality report execution failed due to errors.
        /// </summary>
        Failed,
        
        /// <summary>
        /// Quality report execution was manually cancelled.
        /// </summary>
        Cancelled
    }
}
