namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the severity of a review comment.
    /// </summary>
    public enum ReviewCommentSeverity
    {
        /// <summary>
        /// Blocking severity (must be addressed).
        /// </summary>
        Blocking,
        /// <summary>
        /// Major severity.
        /// </summary>
        Major,
        /// <summary>
        /// Minor severity.
        /// </summary>
        Minor,
        /// <summary>
        /// Suggestion (optional improvement).
        /// </summary>
        Suggestion
    }
}
