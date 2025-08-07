namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents metrics for pipeline executions.
    /// </summary>
    public class PipelineMetrics
    {
        /// <summary>
        /// Success rate of pipeline executions.
        /// </summary>
        public double SuccessRate { get; set; }
        /// <summary>
        /// Average duration of pipeline executions.
        /// </summary>
        public TimeSpan AverageDuration { get; set; }
        /// <summary>
        /// Total number of executions.
        /// </summary>
        public int TotalExecutions { get; set; }
        /// <summary>
        /// Number of successful executions.
        /// </summary>
        public int SuccessfulExecutions { get; set; }
        /// <summary>
        /// Number of failed executions.
        /// </summary>
        public int FailedExecutions { get; set; }
        /// <summary>
        /// Number of cancelled executions.
        /// </summary>
        public int CancelledExecutions { get; set; }
        /// <summary>
        /// Fastest execution time.
        /// </summary>
        public TimeSpan FastestExecution { get; set; }
        /// <summary>
        /// Slowest execution time.
        /// </summary>
        public TimeSpan SlowestExecution { get; set; }
        /// <summary>
        /// Custom metrics for the pipeline.
        /// </summary>
        public Dictionary<string, object> CustomMetrics { get; set; } = new();
        /// <summary>
        /// Last update timestamp for metrics.
        /// </summary>
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}
