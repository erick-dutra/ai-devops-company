namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the network configuration for an infrastructure resource.
    /// </summary>
    public class NetworkConfiguration
    {
        /// <summary>
        /// Network identifier.
        /// </summary>
        public string NetworkId { get; set; } = string.Empty;
        /// <summary>
        /// Subnet identifier.
        /// </summary>
        public string SubnetId { get; set; } = string.Empty;
        /// <summary>
        /// IP address assigned to the resource.
        /// </summary>
        public string IpAddress { get; set; } = string.Empty;
        /// <summary>
        /// Indicates if public access is allowed.
        /// </summary>
        public bool PublicAccess { get; set; }
        /// <summary>
        /// List of open ports for the resource.
        /// </summary>
        public List<int> OpenPorts { get; set; } = new();
        /// <summary>
        /// Load balancer identifier associated with the network.
        /// </summary>
        public string LoadBalancerId { get; set; } = string.Empty;
    }
}
