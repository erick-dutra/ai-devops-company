namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the trigger for scaling actions in the infrastructure.
    /// </summary>
    public enum ScalingTrigger
    {
        /// <summary>Scaling based on CPU utilization.</summary>
        CpuUtilization,
        /// <summary>Scaling based on memory utilization.</summary>
        MemoryUtilization,
        /// <summary>Scaling based on network utilization.</summary>
        NetworkUtilization,
        /// <summary>Scaling based on request count.</summary>
        RequestCount,
        /// <summary>Scaling based on response time.</summary>
        ResponseTime,
        /// <summary>Scaling based on queue length.</summary>
        QueueLength,
        /// <summary>Custom scaling trigger.</summary>
        Custom
    }
}
