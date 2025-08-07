namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a condition that determines whether a pipeline job should run, based on type, expression, and dependencies.
    /// </summary>
    public class JobCondition
    {
        /// <summary>
        /// Type of the condition (e.g., Always, OnSuccess, Custom).
        /// </summary>
        public ConditionType Type { get; set; }
        /// <summary>
        /// Custom expression to evaluate the condition.
        /// </summary>
        public string Expression { get; set; } = string.Empty;
        /// <summary>
        /// List of job IDs that this condition depends on.
        /// </summary>
        public List<string> DependsOn { get; set; } = new();
        /// <summary>
        /// Indicates if the job should continue on error.
        /// </summary>
        public bool ContinueOnError { get; set; }
    }
}
