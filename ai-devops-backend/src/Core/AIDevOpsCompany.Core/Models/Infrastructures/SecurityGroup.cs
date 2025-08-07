namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents a security group, including inbound and outbound rules.
    /// </summary>
    public class SecurityGroup
    {
        /// <summary>
        /// Unique identifier for the security group.
        /// </summary>
        public string GroupId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the security group.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// List of inbound security rules.
        /// </summary>
        public List<SecurityRule> InboundRules { get; set; } = new();
        /// <summary>
        /// List of outbound security rules.
        /// </summary>
        public List<SecurityRule> OutboundRules { get; set; } = new();
    }
}
