namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents a quality assessment for an agent.
    /// </summary>
    public class QualityAssessment
    {
        /// <summary>
        /// Unique identifier for the quality assessment.
        /// </summary>
        public string AssessmentId { get; set; } = string.Empty;
        /// <summary>
        /// Type of the quality assessment.
        /// </summary>
        public QualityAssessmentType Type { get; set; }
        /// <summary>
        /// Score assigned in the quality assessment.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Comments or notes about the assessment.
        /// </summary>
        public string Comments { get; set; } = string.Empty;
        /// <summary>
        /// Identifier of the agent who performed the assessment.
        /// </summary>
        public string AssessedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the assessment was performed.
        /// </summary>
        public DateTime AssessedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// List of areas where the agent demonstrated strength.
        /// </summary>
        public List<string> StrengthAreas { get; set; } = new();
        /// <summary>
        /// List of areas where the agent can improve.
        /// </summary>
        public List<string> ImprovementAreas { get; set; } = new();
    }
}
