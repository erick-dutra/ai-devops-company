namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the type of review comment made during a code review.
    /// </summary>
    public enum ReviewCommentType
    {
        /// <summary>
        /// Suggestion for improvement.
        /// </summary>
        Suggestion,
        /// <summary>
        /// Issue or problem identified.
        /// </summary>
        Issue,
        /// <summary>
        /// Question about the code.
        /// </summary>
        Question,
        /// <summary>
        /// Praise for good code or practice.
        /// </summary>
        Praise,
        /// <summary>
        /// Nitpick or minor comment.
        /// </summary>
        Nitpick
    }
}
