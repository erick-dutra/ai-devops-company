namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents security configuration settings for infrastructure, including encryption, access, and compliance.
    /// </summary>
    public class SecurityConfiguration
    {
        /// <summary>
        /// Indicates if encryption at rest is enabled.
        /// </summary>
        public bool EncryptionAtRest { get; set; }
        /// <summary>
        /// Indicates if encryption in transit is enabled.
        /// </summary>
        public bool EncryptionInTransit { get; set; }
        /// <summary>
        /// KMS key ID used for encryption.
        /// </summary>
        public string KmsKeyId { get; set; } = string.Empty;
        /// <summary>
        /// List of allowed IP ranges for access.
        /// </summary>
        public List<string> AllowedIpRanges { get; set; } = new();
        /// <summary>
        /// Indicates if VPN is required for access.
        /// </summary>
        public bool VpnRequired { get; set; }
        /// <summary>
        /// Indicates if multi-factor authentication (MFA) is required.
        /// </summary>
        public bool MfaRequired { get; set; }
        /// <summary>
        /// List of security policies applied.
        /// </summary>
        public List<SecurityPolicy> Policies { get; set; } = new();
        /// <summary>
        /// Compliance requirements for the configuration.
        /// </summary>
        public ComplianceRequirements Compliance { get; set; } = new();
    }
}
