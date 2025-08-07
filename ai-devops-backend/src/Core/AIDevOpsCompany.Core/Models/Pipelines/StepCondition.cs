namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a condition that must be met for a pipeline step to execute.
    /// </summary>
    public class StepCondition
    {
        /// <summary>
        /// The type of condition.
        /// </summary>
        public ConditionType Type { get; set; }
        /// <summary>
        /// The condition expression.
        /// </summary>
        public string Expression { get; set; } = string.Empty;
        /// <summary>
        /// Whether to continue on error.
        /// </summary>
        public bool ContinueOnError { get; set; }
    }
}
