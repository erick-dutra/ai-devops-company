namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the status of an infrastructure resource.
    /// </summary>
    public enum InfrastructureStatus
    {
        /// <summary>Infrastructure is in planning phase.</summary>
        Planning,
        /// <summary>Infrastructure is being provisioned.</summary>
        Provisioning,
        /// <summary>Infrastructure is active and operational.</summary>
        Active,
        /// <summary>Infrastructure is being updated.</summary>
        Updating,
        /// <summary>Infrastructure is scaling.</summary>
        Scaling,
        /// <summary>Infrastructure is under maintenance.</summary>
        Maintenance,
        /// <summary>Infrastructure has failed.</summary>
        Failed,
        /// <summary>Infrastructure is being decommissioned.</summary>
        Decommissioning,
        /// <summary>Infrastructure has been decommissioned.</summary>
        Decommissioned
    }
}
