namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents learning and adaptability metrics for an agent's performance.
    /// </summary>
    public class LearningMetrics
    {
        /// <summary>
        /// Gets or sets the learning rate.
        /// </summary>
        public double LearningRate { get; set; }

        /// <summary>
        /// Gets or sets the adaptability score.
        /// </summary>
        public double AdaptabilityScore { get; set; }

        /// <summary>
        /// Gets or sets the skill improvement rate.
        /// </summary>
        public double SkillImprovementRate { get; set; }

        /// <summary>
        /// Gets or sets the number of new skills acquired.
        /// </summary>
        public int NewSkillsAcquired { get; set; }

        /// <summary>
        /// Gets or sets the number of training sessions completed.
        /// </summary>
        public int TrainingSessionsCompleted { get; set; }

        /// <summary>
        /// Gets or sets the number of certifications earned.
        /// </summary>
        public int CertificationsEarned { get; set; }

        /// <summary>
        /// Gets or sets the knowledge retention rate.
        /// </summary>
        public double KnowledgeRetentionRate { get; set; }

        /// <summary>
        /// Gets or sets the innovation score.
        /// </summary>
        public double InnovationScore { get; set; }

        /// <summary>
        /// Gets or sets the number of experiments performed.
        /// </summary>
        public int ExperimentsPerformed { get; set; }

        /// <summary>
        /// Gets or sets the number of successful experiments.
        /// </summary>
        public int SuccessfulExperiments { get; set; }

        /// <summary>
        /// Gets or sets the list of learning achievements.
        /// </summary>
        public List<LearningAchievement> Achievements { get; set; } = new();

        /// <summary>
        /// Gets or sets the list of skill assessments.
        /// </summary>
        public List<SkillAssessment> SkillAssessments { get; set; } = new();
    }
}
