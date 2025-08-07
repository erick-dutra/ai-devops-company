namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the type of cost optimization recommendation.
    /// </summary>
    public enum CostOptimizationType
    {
        /// <summary>
        /// Right-sizing resources.
        /// </summary>
        RightSizing,
        /// <summary>
        /// Using reserved instances.
        /// </summary>
        ReservedInstances,
        /// <summary>
        /// Using spot instances.
        /// </summary>
        SpotInstances,
        /// <summary>
        /// Optimizing storage usage.
        /// </summary>
        StorageOptimization,
        /// <summary>
        /// Optimizing network usage.
        /// </summary>
        NetworkOptimization,
        /// <summary>
        /// Scheduling shutdowns for unused resources.
        /// </summary>
        ScheduledShutdown,
        /// <summary>
        /// Using auto-scaling to optimize costs.
        /// </summary>
        AutoScaling
    }
}
