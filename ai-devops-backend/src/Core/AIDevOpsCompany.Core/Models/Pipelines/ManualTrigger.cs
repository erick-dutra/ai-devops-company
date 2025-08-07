namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a manual trigger configuration for pipeline execution.
    /// </summary>
    public class ManualTrigger
    {
        /// <summary>
        /// Whether approval is required.
        /// </summary>
        public bool RequireApproval { get; set; }
        /// <summary>
        /// List of approvers.
        /// </summary>
        public List<string> Approvers { get; set; } = new();
        /// <summary>
        /// Reason for manual trigger.
        /// </summary>
        public string Reason { get; set; } = string.Empty;
    }
}
