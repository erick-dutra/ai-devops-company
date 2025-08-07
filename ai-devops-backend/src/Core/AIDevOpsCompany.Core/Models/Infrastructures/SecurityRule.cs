namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents a security rule for network access, including protocol, ports, and source.
    /// </summary>
    public class SecurityRule
    {
        /// <summary>
        /// Network protocol (e.g., TCP, UDP).
        /// </summary>
        public string Protocol { get; set; } = string.Empty;
        /// <summary>
        /// Starting port of the allowed range.
        /// </summary>
        public int FromPort { get; set; }
        /// <summary>
        /// Ending port of the allowed range.
        /// </summary>
        public int ToPort { get; set; }
        /// <summary>
        /// Source IP or CIDR range allowed by the rule.
        /// </summary>
        public string Source { get; set; } = string.Empty;
        /// <summary>
        /// Description of the security rule.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
