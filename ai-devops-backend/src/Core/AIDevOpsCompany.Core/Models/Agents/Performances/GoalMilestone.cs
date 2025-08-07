namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents a milestone within a performance goal.
    /// </summary>
    public class GoalMilestone
    {
        /// <summary>
        /// Unique identifier for the milestone.
        /// </summary>
        public string MilestoneId { get; set; } = string.Empty;
        /// <summary>
        /// Title of the milestone.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Description of the milestone.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Target value to be achieved for the milestone.
        /// </summary>
        public double TargetValue { get; set; }
        /// <summary>
        /// Date by which the milestone should be achieved.
        /// </summary>
        public DateTime TargetDate { get; set; }
        /// <summary>
        /// Indicates whether the milestone has been completed.
        /// </summary>
        public bool Completed { get; set; }
        /// <summary>
        /// Date when the milestone was completed, if applicable.
        /// </summary>
        public DateTime? CompletedDate { get; set; }
    }
}
