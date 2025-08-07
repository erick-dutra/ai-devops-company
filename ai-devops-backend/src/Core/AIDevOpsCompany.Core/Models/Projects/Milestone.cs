namespace AIDevOpsCompany.Core.Models.Projects
{
    /// <summary>
    /// Represents a project milestone, including its status, due date, and dependencies.
    /// </summary>
    public class Milestone
    {
        /// <summary>
        /// Gets or sets the unique identifier for the milestone.
        /// </summary>
        public string MilestoneId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the milestone.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description of the milestone.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the due date for the milestone.
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Gets or sets the date when the milestone was completed, if applicable.
        /// </summary>
        public DateTime? CompletedDate { get; set; }
        /// <summary>
        /// Gets or sets the status of the milestone.
        /// </summary>
        public MilestoneStatus Status { get; set; } = MilestoneStatus.Pending;
        /// <summary>
        /// Gets or sets the list of dependencies for the milestone.
        /// </summary>
        public List<string> Dependencies { get; set; } = new();
        /// <summary>
        /// Gets or sets the identifier of the agent responsible for the milestone.
        /// </summary>
        public string ResponsibleAgentId { get; set; } = string.Empty;
    }
}
