namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents usage metrics for financial analysis, including compute, storage, and network usage.
    /// </summary>
    public class UsageMetrics
    {
        /// <summary>
        /// Total compute hours used.
        /// </summary>
        public decimal ComputeHours { get; set; }
        /// <summary>
        /// Total storage used in gigabytes.
        /// </summary>
        public decimal StorageGB { get; set; }
        /// <summary>
        /// Total network transfer in gigabytes.
        /// </summary>
        public decimal NetworkGBTransfer { get; set; }
        /// <summary>
        /// Number of database transactions performed.
        /// </summary>
        public decimal DatabaseTransactions { get; set; }
        /// <summary>
        /// Number of API requests made.
        /// </summary>
        public decimal APIRequests { get; set; }
        /// <summary>
        /// Number of function executions performed.
        /// </summary>
        public decimal FunctionExecutions { get; set; }
        /// <summary>
        /// Custom usage metrics for extensibility.
        /// </summary>
        public Dictionary<string, decimal> CustomMetrics { get; set; } = new();
    }
}
