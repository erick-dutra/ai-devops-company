namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the status of a post-incident review.
    /// </summary>
    public enum PostIncidentReviewStatus
    {
        /// <summary>Review is pending.</summary>
        Pending,
        /// <summary>Review is scheduled.</summary>
        Scheduled,
        /// <summary>Review is in progress.</summary>
        InProgress,
        /// <summary>Review is completed.</summary>
        Completed,
        /// <summary>Review is cancelled.</summary>
        Cancelled
    }
}
