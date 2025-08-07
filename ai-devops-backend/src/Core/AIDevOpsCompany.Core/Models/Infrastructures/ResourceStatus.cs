namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the status of a resource in the infrastructure.
    /// </summary>
    public enum ResourceStatus
    {
        /// <summary>Resource is planned but not yet provisioned.</summary>
        Planned,
        /// <summary>Resource is being provisioned.</summary>
        Provisioning,
        /// <summary>Resource is running and operational.</summary>
        Running,
        /// <summary>Resource is stopped.</summary>
        Stopped,
        /// <summary>Resource has failed.</summary>
        Failed,
        /// <summary>Resource is being updated.</summary>
        Updating,
        /// <summary>Resource is being terminated.</summary>
        Terminating,
        /// <summary>Resource has been terminated.</summary>
        Terminated
    }
}
