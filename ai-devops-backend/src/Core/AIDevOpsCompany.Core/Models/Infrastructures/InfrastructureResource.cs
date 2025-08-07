namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents an infrastructure resource, such as a VM, database, or storage.
    /// </summary>
    public class InfrastructureResource
    {
        /// <summary>
        /// Gets or sets the unique identifier for the resource.
        /// </summary>
        public string ResourceId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        public ResourceType Type { get; set; }
        /// <summary>
        /// Gets or sets the size of the resource.
        /// </summary>
        public string Size { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the configuration for the resource.
        /// </summary>
        public ResourceConfiguration Configuration { get; set; } = new();
        /// <summary>
        /// Gets or sets the status of the resource.
        /// </summary>
        public ResourceStatus Status { get; set; } = ResourceStatus.Planned;
        /// <summary>
        /// Gets or sets the external cloud provider resource ID.
        /// </summary>
        public string ExternalId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the endpoint for accessing the resource.
        /// </summary>
        public string Endpoint { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the list of dependencies for the resource.
        /// </summary>
        public List<string> Dependencies { get; set; } = new();
        /// <summary>
        /// Gets or sets the metrics for the resource.
        /// </summary>
        public ResourceMetrics Metrics { get; set; } = new();
        /// <summary>
        /// Gets or sets the cost breakdown for the resource.
        /// </summary>
        public InfraCostBreakdown Cost { get; set; } = new();
        /// <summary>
        /// Gets or sets the date and time when the resource was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the date and time when the resource was provisioned, if applicable.
        /// </summary>
        public DateTime? ProvisionedAt { get; set; }
        /// <summary>
        /// Gets or sets additional metadata for the resource.
        /// </summary>
        public Dictionary<string, object> Metadata { get; set; } = new();
    }
}
