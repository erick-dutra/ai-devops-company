namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the types of collaboration events that can occur among agents.
    /// </summary>
    public enum CollaborationEventType
    {
        /// <summary>
        /// Event where knowledge is shared among team members.
        /// </summary>
        KnowledgeSharing,
        /// <summary>
        /// Event focused on solving problems collaboratively.
        /// </summary>
        ProblemSolving,
        /// <summary>
        /// Event involving mentoring or coaching activities.
        /// </summary>
        Mentoring,
        /// <summary>
        /// Event aimed at resolving conflicts within the team.
        /// </summary>
        ConflictResolution,
        /// <summary>
        /// Regular or ad-hoc team meetings.
        /// </summary>
        TeamMeeting,
        /// <summary>
        /// Collaborative programming session between two or more developers.
        /// </summary>
        PairProgramming,
        /// <summary>
        /// Event for reviewing code collaboratively.
        /// </summary>
        CodeReview
    }
}
