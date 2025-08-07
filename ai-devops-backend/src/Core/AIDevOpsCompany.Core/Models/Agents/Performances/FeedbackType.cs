namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the type of feedback provided in agent performance evaluations.
    /// </summary>
    public enum FeedbackType
    {
        /// <summary>Positive feedback.</summary>
        Positive,
        /// <summary>Constructive feedback.</summary>
        Constructive,
        /// <summary>Negative feedback.</summary>
        Negative,
        /// <summary>Suggestion for improvement.</summary>
        Suggestion,
        /// <summary>Recognition of achievement or excellence.</summary>
        Recognition,
        /// <summary>Expression of concern.</summary>
        Concern
    }
}
