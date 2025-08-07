namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents a security policy, including rules and enforcement status.
    /// </summary>
    public class SecurityPolicy
    {
        /// <summary>
        /// Unique identifier for the security policy.
        /// </summary>
        public string PolicyId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the security policy.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Description of the security policy.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// List of rules included in the policy.
        /// </summary>
        public List<string> Rules { get; set; } = new();
        /// <summary>
        /// Indicates if the policy is enforced.
        /// </summary>
        public bool Enforced { get; set; }
    }
}
