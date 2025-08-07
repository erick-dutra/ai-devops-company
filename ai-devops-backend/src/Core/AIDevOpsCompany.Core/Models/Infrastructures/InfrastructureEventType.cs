namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the type of event that can occur in the infrastructure.
    /// </summary>
    public enum InfrastructureEventType
    {
        /// <summary>
        /// Resource was provisioned.
        /// </summary>
        Provisioned,
        /// <summary>
        /// Resource was started.
        /// </summary>
        Started,
        /// <summary>
        /// Resource was stopped.
        /// </summary>
        Stopped,
        /// <summary>
        /// Resource was scaled.
        /// </summary>
        Scaled,
        /// <summary>
        /// Resource was updated.
        /// </summary>
        Updated,
        /// <summary>
        /// Resource failed.
        /// </summary>
        Failed,
        /// <summary>
        /// Resource recovered from failure.
        /// </summary>
        Recovered,
        /// <summary>
        /// Resource was decommissioned.
        /// </summary>
        Decommissioned,
        /// <summary>
        /// Security alert event.
        /// </summary>
        SecurityAlert,
        /// <summary>
        /// Cost alert event.
        /// </summary>
        CostAlert,
        /// <summary>
        /// Performance alert event.
        /// </summary>
        PerformanceAlert
    }
}
