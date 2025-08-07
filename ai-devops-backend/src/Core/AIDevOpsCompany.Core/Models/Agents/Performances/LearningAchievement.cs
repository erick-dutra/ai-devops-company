namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents a learning achievement accomplished by an agent.
    /// </summary>
    public class LearningAchievement
    {
        /// <summary>
        /// Unique identifier for the learning achievement.
        /// </summary>
        public string AchievementId { get; set; } = string.Empty;
        /// <summary>
        /// Title of the learning achievement.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Description of the learning achievement.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of achievement (e.g., certification, course completion).
        /// </summary>
        public AchievementType Type { get; set; }
        /// <summary>
        /// Date and time when the achievement was accomplished.
        /// </summary>
        public DateTime AchievedAt { get; set; }
        /// <summary>
        /// Evidence or proof of the achievement.
        /// </summary>
        public string Evidence { get; set; } = string.Empty;
        /// <summary>
        /// Impact score of the achievement.
        /// </summary>
        public double ImpactScore { get; set; }
    }
}
