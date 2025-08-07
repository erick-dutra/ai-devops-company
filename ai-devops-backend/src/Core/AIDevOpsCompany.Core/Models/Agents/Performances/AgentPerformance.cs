namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents the performance evaluation of an AI agent.
    /// </summary>
    public class AgentPerformance
    {
        /// <summary>
        /// Unique identifier for the performance record.
        /// </summary>
        public string PerformanceId { get; set; } = string.Empty;
        /// <summary>
        /// Unique identifier for the agent.
        /// </summary>
        public string AgentId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the agent.
        /// </summary>
        public string AgentName { get; set; } = string.Empty;
        /// <summary>
        /// Role of the agent.
        /// </summary>
        public string AgentRole { get; set; } = string.Empty;
        /// <summary>
        /// Evaluation period.
        /// </summary>
        public PerformancePeriod Period { get; set; } = new();
        /// <summary>
        /// General performance metrics.
        /// </summary>
        public PerformanceMetrics Metrics { get; set; } = new();
        /// <summary>
        /// Quality metrics.
        /// </summary>
        public QualityMetrics Quality { get; set; } = new();
        /// <summary>
        /// Efficiency metrics.
        /// </summary>
        public EfficiencyMetrics Efficiency { get; set; } = new();
        /// <summary>
        /// Reliability metrics.
        /// </summary>
        public ReliabilityMetrics Reliability { get; set; } = new();
        /// <summary>
        /// Collaboration metrics.
        /// </summary>
        public CollaborationMetrics Collaboration { get; set; } = new();
        /// <summary>
        /// Learning metrics.
        /// </summary>
        public LearningMetrics Learning { get; set; } = new();
        /// <summary>
        /// List of performance goals.
        /// </summary>
        public List<PerformanceGoal> Goals { get; set; } = new();
        /// <summary>
        /// List of performance issues.
        /// </summary>
        public List<PerformanceIssue> Issues { get; set; } = new();
        /// <summary>
        /// List of performance improvements.
        /// </summary>
        public List<PerformanceImprovement> Improvements { get; set; } = new();
        /// <summary>
        /// Overall rating for the agent.
        /// </summary>
        public OverallRating OverallRating { get; set; } = new();
        /// <summary>
        /// List of feedback entries.
        /// </summary>
        public List<Feedback> Feedback { get; set; } = new();
        /// <summary>
        /// Agent who performed the evaluation.
        /// </summary>
        public string EvaluatedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Date and time when the evaluation was performed.
        /// </summary>
        public DateTime EvaluatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date for the next scheduled evaluation.
        /// </summary>
        public DateTime NextEvaluationDate { get; set; }
        /// <summary>
        /// Custom metrics for extensibility.
        /// </summary>
        public Dictionary<string, object> CustomMetrics { get; set; } = new();
    }
}
