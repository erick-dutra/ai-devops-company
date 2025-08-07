namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents metrics collected for an infrastructure resource.
    /// </summary>
    public class ResourceMetrics
    {
        /// <summary>
        /// CPU utilization percentage.
        /// </summary>
        public double CpuUtilization { get; set; }
        /// <summary>
        /// Memory utilization percentage.
        /// </summary>
        public double MemoryUtilization { get; set; }
        /// <summary>
        /// Disk utilization percentage.
        /// </summary>
        public double DiskUtilization { get; set; }
        /// <summary>
        /// Network inbound traffic in Mbps.
        /// </summary>
        public double NetworkInMbps { get; set; }
        /// <summary>
        /// Network outbound traffic in Mbps.
        /// </summary>
        public double NetworkOutMbps { get; set; }
        /// <summary>
        /// Number of active connections.
        /// </summary>
        public int ActiveConnections { get; set; }
        /// <summary>
        /// Average response time in milliseconds.
        /// </summary>
        public double ResponseTime { get; set; }
        /// <summary>
        /// Availability percentage.
        /// </summary>
        public double Availability { get; set; }
        /// <summary>
        /// Date and time when metrics were last updated.
        /// </summary>
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Custom metrics for extensibility.
        /// </summary>
        public Dictionary<string, object> CustomMetrics { get; set; } = new();
    }
}
