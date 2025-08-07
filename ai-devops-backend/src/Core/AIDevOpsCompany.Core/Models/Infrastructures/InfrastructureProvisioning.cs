namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the provisioning of infrastructure resources for a project.
    /// </summary>
    public class InfrastructureProvisioning
    {
        /// <summary>
        /// Gets or sets the unique identifier for the provisioning operation.
        /// </summary>
        public string ProvisioningId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the identifier of the related project.
        /// </summary>
        public string ProjectId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the name of the provisioning operation.
        /// </summary>
        public string ProvisioningName { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description of the provisioning operation.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the cloud provider used for provisioning.
        /// </summary>
        public CloudProvider Provider { get; set; }
        /// <summary>
        /// Gets or sets the cloud region where resources are provisioned.
        /// </summary>
        public string Region { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the list of infrastructure resources provisioned.
        /// </summary>
        public List<InfrastructureResource> Resources { get; set; } = new();
        /// <summary>
        /// Gets or sets the current status of the provisioning operation.
        /// </summary>
        public InfrastructureStatus Status { get; set; } = InfrastructureStatus.Planning;
        /// <summary>
        /// Gets or sets the configuration details for the infrastructure.
        /// </summary>
        public InfrastructureConfiguration Configuration { get; set; } = new();
        /// <summary>
        /// Gets or sets the estimated cost for the provisioned resources.
        /// </summary>
        public CostEstimate CostEstimate { get; set; } = new();
        /// <summary>
        /// Gets or sets the security configuration for the infrastructure.
        /// </summary>
        public SecurityConfiguration SecurityConfig { get; set; } = new();
        /// <summary>
        /// Gets or sets the monitoring configuration for the infrastructure.
        /// </summary>
        public MonitoringConfiguration MonitoringConfig { get; set; } = new();
        /// <summary>
        /// Gets or sets the backup configuration for the infrastructure.
        /// </summary>
        public BackupConfiguration BackupConfig { get; set; } = new();
        /// <summary>
        /// Gets or sets the list of events related to the provisioning operation.
        /// </summary>
        public List<InfrastructureEvent> Events { get; set; } = new();
        /// <summary>
        /// Gets or sets the identifier of the agent who performed the provisioning.
        /// </summary>
        public string ProvisionedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the date and time when the provisioning was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Gets or sets the date and time when the provisioning was completed.
        /// </summary>
        public DateTime? ProvisionedAt { get; set; }
        /// <summary>
        /// Gets or sets the date and time when the infrastructure was decommissioned.
        /// </summary>
        public DateTime? DecommissionedAt { get; set; }
        /// <summary>
        /// Gets or sets tags for categorizing or identifying the provisioning operation.
        /// </summary>
        public Dictionary<string, object> Tags { get; set; } = new();
    }
}
