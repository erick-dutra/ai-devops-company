namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents a performance goal assigned to an agent.
    /// </summary>
    public class PerformanceGoal
    {
        /// <summary>
        /// Unique identifier for the performance goal.
        /// </summary>
        public string GoalId { get; set; } = string.Empty;
        /// <summary>
        /// Title of the performance goal.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Description of the performance goal.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Type of the performance goal.
        /// </summary>
        public GoalType Type { get; set; }
        /// <summary>
        /// Priority of the performance goal.
        /// </summary>
        public GoalPriority Priority { get; set; }
        /// <summary>
        /// Status of the performance goal.
        /// </summary>
        public GoalStatus Status { get; set; } = GoalStatus.Active;
        /// <summary>
        /// Target value to be achieved for the goal.
        /// </summary>
        public double TargetValue { get; set; }
        /// <summary>
        /// Current value achieved towards the goal.
        /// </summary>
        public double CurrentValue { get; set; }
        /// <summary>
        /// Progress percentage towards the goal.
        /// </summary>
        public double ProgressPercentage { get; set; }
        /// <summary>
        /// Start date of the performance goal.
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Target date by which the goal should be achieved.
        /// </summary>
        public DateTime TargetDate { get; set; }
        /// <summary>
        /// Date when the goal was completed, if applicable.
        /// </summary>
        public DateTime? CompletedDate { get; set; }
        /// <summary>
        /// Metric used to measure the goal.
        /// </summary>
        public string Metric { get; set; } = string.Empty;
        /// <summary>
        /// List of milestones associated with the goal.
        /// </summary>
        public List<GoalMilestone> Milestones { get; set; } = new();
        /// <summary>
        /// Identifier of the agent who created the goal.
        /// </summary>
        public string CreatedByAgentId { get; set; } = string.Empty;
    }
}
