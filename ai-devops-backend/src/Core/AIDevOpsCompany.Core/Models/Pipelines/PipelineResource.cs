using System.Security.AccessControl;

namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a resource used in a pipeline.
    /// </summary>
    public class PipelineResource
    {
        /// <summary>
        /// Unique identifier for the resource.
        /// </summary>
        public string ResourceId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the resource.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public ResourceType Type { get; set; }
        /// <summary>
        /// Source of the resource.
        /// </summary>
        public string Source { get; set; } = string.Empty;
        /// <summary>
        /// Version of the resource.
        /// </summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>
        /// Configuration for the resource.
        /// </summary>
        public Dictionary<string, object> Configuration { get; set; } = new();
    }
}
