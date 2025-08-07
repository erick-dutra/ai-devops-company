namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents an assessment of a specific skill for an agent, including levels and improvement.
    /// </summary>
    public class SkillAssessment
    {
        /// <summary>
        /// Gets or sets the unique identifier for the skill assessment.
        /// </summary>
        public string AssessmentId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the skill being assessed.
        /// </summary>
        public string SkillName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the category of the skill.
        /// </summary>
        public SkillCategory Category { get; set; }

        /// <summary>
        /// Gets or sets the current level of the skill.
        /// </summary>
        public double CurrentLevel { get; set; }

        /// <summary>
        /// Gets or sets the previous level of the skill.
        /// </summary>
        public double PreviousLevel { get; set; }

        /// <summary>
        /// Gets or sets the improvement in the skill level.
        /// </summary>
        public double Improvement { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the assessment was performed.
        /// </summary>
        public DateTime AssessedAt { get; set; }

        /// <summary>
        /// Gets or sets the method used for the assessment.
        /// </summary>
        public string AssessmentMethod { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets additional notes about the assessment.
        /// </summary>
        public string Notes { get; set; } = string.Empty;
    }
}
