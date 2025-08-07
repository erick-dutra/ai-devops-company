namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents a point-in-time measurement of system resource utilization during performance testing.
    /// </summary>
    public class ResourceUsageSnapshot
    {
        /// <summary>
        /// Date and time when the resource usage snapshot was taken.
        /// </summary>
        public DateTime Timestamp { get; set; }
        
        /// <summary>
        /// CPU utilization percentage at the time of the snapshot.
        /// </summary>
        public double CpuUsage { get; set; }
        
        /// <summary>
        /// Memory utilization percentage at the time of the snapshot.
        /// </summary>
        public double MemoryUsage { get; set; }
        
        /// <summary>
        /// Disk utilization percentage at the time of the snapshot.
        /// </summary>
        public double DiskUsage { get; set; }
        
        /// <summary>
        /// Network bandwidth utilization percentage at the time of the snapshot.
        /// </summary>
        public double NetworkUsage { get; set; }
    }
}
