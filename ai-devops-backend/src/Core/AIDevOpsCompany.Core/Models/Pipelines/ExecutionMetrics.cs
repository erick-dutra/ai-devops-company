namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents execution metrics for a pipeline run, including timings, step counts, and artifact statistics.
    /// </summary>
    public class ExecutionMetrics
    {
        /// <summary>
        /// Time spent in the queue before execution started.
        /// </summary>
        public TimeSpan QueueTime { get; set; }
        /// <summary>
        /// Time spent executing the pipeline.
        /// </summary>
        public TimeSpan ExecutionTime { get; set; }
        /// <summary>
        /// Total time from queue to completion.
        /// </summary>
        public TimeSpan TotalTime { get; set; }
        /// <summary>
        /// Total number of steps in the pipeline.
        /// </summary>
        public int TotalSteps { get; set; }
        /// <summary>
        /// Number of steps that succeeded.
        /// </summary>
        public int SuccessfulSteps { get; set; }
        /// <summary>
        /// Number of steps that failed.
        /// </summary>
        public int FailedSteps { get; set; }
        /// <summary>
        /// Number of steps that were skipped.
        /// </summary>
        public int SkippedSteps { get; set; }
        /// <summary>
        /// Total size of all artifacts produced, in bytes.
        /// </summary>
        public long ArtifactsSizeBytes { get; set; }
        /// <summary>
        /// Total number of artifacts produced.
        /// </summary>
        public int ArtifactsCount { get; set; }
        /// <summary>
        /// Timings for each stage in the pipeline.
        /// </summary>
        public Dictionary<string, TimeSpan> StageTimings { get; set; } = new();
        /// <summary>
        /// Custom metrics for extensibility.
        /// </summary>
        public Dictionary<string, object> CustomMetrics { get; set; } = new();
    }
}
