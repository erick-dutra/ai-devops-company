namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a condition that must be met for a pipeline stage to execute.
    /// </summary>
    public class StageCondition
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
        /// List of dependencies for the stage.
        /// </summary>
        public List<string> DependsOn { get; set; } = new();
        /// <summary>
        /// Whether to continue on error.
        /// </summary>
        public bool ContinueOnError { get; set; }
    }
}
