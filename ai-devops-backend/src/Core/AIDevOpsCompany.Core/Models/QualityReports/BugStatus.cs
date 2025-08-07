namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Defines the possible states of a bug within its lifecycle.
    /// </summary>
    public enum BugStatus
    {
        /// <summary>
        /// Bug has been reported but not yet assigned or addressed.
        /// </summary>
        Open,
        
        /// <summary>
        /// Bug is currently being worked on by a developer or agent.
        /// </summary>
        InProgress,
        
        /// <summary>
        /// Bug has been fixed but not yet verified.
        /// </summary>
        Fixed,
        
        /// <summary>
        /// Bug fix has been verified by testing or QA.
        /// </summary>
        Verified,
        
        /// <summary>
        /// Bug has been completely resolved and closed.
        /// </summary>
        Closed,
        
        /// <summary>
        /// Bug report has been rejected as invalid or not reproducible.
        /// </summary>
        Rejected,
        
        /// <summary>
        /// Bug is a duplicate of another existing bug report.
        /// </summary>
        Duplicate
    }
}
