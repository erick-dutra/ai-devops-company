namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Specifies the status of a clarification question.
    /// </summary>
    public enum QuestionStatus
    {
        /// <summary>Question is open and awaiting answer.</summary>
        Open,
        /// <summary>Question has been answered.</summary>
        Answered,
        /// <summary>Question has been clarified.</summary>
        Clarified,
        /// <summary>Question is closed.</summary>
        Closed
    }
}
