namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents a step within an improvement plan or process.
    /// </summary>
    public class ImprovementStep
    {
        /// <summary>
        /// Unique identifier for the improvement step.
        /// </summary>
        public string StepId { get; set; } = string.Empty;
        /// <summary>
        /// Description of the improvement step.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Order or sequence of the step in the improvement plan.
        /// </summary>
        public int Order { get; set; }
        /// <summary>
        /// Status of the improvement step.
        /// </summary>
        public ImprovementStepStatus Status { get; set; } = ImprovementStepStatus.Pending;
        /// <summary>
        /// Date when the step was completed, if applicable.
        /// </summary>
        public DateTime? CompletedDate { get; set; }
        /// <summary>
        /// Result or outcome of the step.
        /// </summary>
        public string Result { get; set; } = string.Empty;
    }
}
