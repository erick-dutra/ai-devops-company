namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents financial metrics and profitability for a client.
    /// </summary>
    public class ClientFinancials
    {
        /// <summary>
        /// Unique identifier for the client.
        /// </summary>
        public string ClientId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the client.
        /// </summary>
        public string ClientName { get; set; } = string.Empty;
        /// <summary>
        /// Total revenue generated from the client.
        /// </summary>
        public decimal TotalRevenue { get; set; }
        /// <summary>
        /// Average value of projects for the client.
        /// </summary>
        public decimal AverageProjectValue { get; set; }
        /// <summary>
        /// Number of projects completed for the client.
        /// </summary>
        public int NumberOfProjects { get; set; }
        /// <summary>
        /// Profit margin for the client.
        /// </summary>
        public decimal ProfitMargin { get; set; }
        /// <summary>
        /// Compliance with payment terms (percentage).
        /// </summary>
        public decimal PaymentTermsCompliance { get; set; }
        /// <summary>
        /// Profitability tier classification for the client.
        /// </summary>
        public ClientProfitabilityTier ProfitabilityTier { get; set; }
    }
}
