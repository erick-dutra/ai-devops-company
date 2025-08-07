using AIDevOpsCompany.Core.Models.Agents.Performances;

namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a qualitative assessment of software quality performed by an agent.
    /// </summary>
    public class QualityAssessment
    {
        /// <summary>
        /// Unique identifier for the assessment.
        /// </summary>
        public string AssessmentId { get; set; } = string.Empty;
        
        /// <summary>
        /// Type of quality assessment performed.
        /// </summary>
        public QualityAssessmentType Type { get; set; }
        
        /// <summary>
        /// Numerical score assigned during the assessment (typically 0-100).
        /// </summary>
        public double Score { get; set; }
        
        /// <summary>
        /// Qualitative comments explaining the assessment.
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
        /// List of areas identified as strengths during the assessment.
        /// </summary>
        public List<string> StrengthAreas { get; set; } = new();
        
        /// <summary>
        /// List of areas identified for improvement during the assessment.
        /// </summary>
        public List<string> ImprovementAreas { get; set; } = new();
    }
}
