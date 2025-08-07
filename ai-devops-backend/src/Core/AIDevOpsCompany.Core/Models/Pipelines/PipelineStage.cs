namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a stage within a pipeline, including jobs, dependencies, and execution settings.
    /// </summary>
    public class PipelineStage
    {
        /// <summary>
        /// Unique identifier for the stage.
        /// </summary>
        public string StageId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the stage.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Description of the stage.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Order of the stage in the pipeline.
        /// </summary>
        public int Order { get; set; }
        /// <summary>
        /// Type of the stage.
        /// </summary>
        public StageType Type { get; set; }
        /// <summary>
        /// List of jobs to be executed in the stage.
        /// </summary>
        public List<PipelineJob> Jobs { get; set; } = new();
        /// <summary>
        /// List of stage dependencies.
        /// </summary>
        public List<string> Dependencies { get; set; } = new();
        /// <summary>
        /// Condition that must be met for the stage to run.
        /// </summary>
        public StageCondition Condition { get; set; } = new();
        /// <summary>
        /// Indicates if jobs in the stage should run in parallel.
        /// </summary>
        public bool Parallel { get; set; }
        /// <summary>
        /// Timeout duration for the stage.
        /// </summary>
        public TimeSpan Timeout { get; set; }
        /// <summary>
        /// Variables and metadata associated with the stage.
        /// </summary>
        public Dictionary<string, object> Variables { get; set; } = new();
    }
}
