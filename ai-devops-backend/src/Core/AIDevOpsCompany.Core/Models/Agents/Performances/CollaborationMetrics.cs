namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents collaboration-related metrics for an agent's performance.
    /// </summary>
    public class CollaborationMetrics
    {
        /// <summary>
        /// Gets or sets the teamwork score.
        /// </summary>
        public double TeamworkScore { get; set; }

        /// <summary>
        /// Gets or sets the communication score.
        /// </summary>
        public double CommunicationScore { get; set; }

        /// <summary>
        /// Gets or sets the knowledge sharing score.
        /// </summary>
        public double KnowledgeSharingScore { get; set; }

        /// <summary>
        /// Gets or sets the number of messages exchanged.
        /// </summary>
        public int MessagesExchanged { get; set; }

        /// <summary>
        /// Gets or sets the number of collaborative tasks completed.
        /// </summary>
        public int CollaborativeTasksCompleted { get; set; }

        /// <summary>
        /// Gets or sets the number of knowledge articles created.
        /// </summary>
        public int KnowledgeArticlesCreated { get; set; }

        /// <summary>
        /// Gets or sets the number of knowledge articles shared.
        /// </summary>
        public int KnowledgeArticlesShared { get; set; }

        /// <summary>
        /// Gets or sets the number of mentoring sessions conducted.
        /// </summary>
        public int MentoringSessions { get; set; }

        /// <summary>
        /// Gets or sets the number of conflicts resolved.
        /// </summary>
        public int ConflictsResolved { get; set; }

        /// <summary>
        /// Gets or sets the conflict resolution score.
        /// </summary>
        public double ConflictResolutionScore { get; set; }

        /// <summary>
        /// Gets or sets the list of collaboration events.
        /// </summary>
        public List<CollaborationEvent> Events { get; set; } = new();
    }
}
