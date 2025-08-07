namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents compliance requirements for infrastructure, such as standards and data residency.
    /// </summary>
    public class ComplianceRequirements
    {
        /// <summary>
        /// List of compliance standards (e.g., SOC2, HIPAA, PCI-DSS).
        /// </summary>
        public List<string> Standards { get; set; } = new();
        /// <summary>
        /// Indicates if data residency is required.
        /// </summary>
        public bool DataResidencyRequired { get; set; }
        /// <summary>
        /// The region where data must reside.
        /// </summary>
        public string DataResidencyRegion { get; set; } = string.Empty;
        /// <summary>
        /// Indicates if audit logging is required.
        /// </summary>
        public bool AuditLoggingRequired { get; set; }
        /// <summary>
        /// Number of days to retain audit logs.
        /// </summary>
        public int LogRetentionDays { get; set; }
    }
}
