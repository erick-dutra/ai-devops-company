namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a comprehensive financial report including revenue, costs, profitability, and breakdowns.
    /// </summary>
    public class FinancialReport
    {
        /// <summary>
        /// Gets or sets the unique identifier for the financial report.
        /// </summary>
        public string ReportId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the financial report.
        /// </summary>
        public FinancialReportType Type { get; set; }

        /// <summary>
        /// Gets or sets the title of the report.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the reporting period for the report.
        /// </summary>
        public ReportPeriod Period { get; set; } = new();

        /// <summary>
        /// Gets or sets the revenue metrics included in the report.
        /// </summary>
        public RevenueMetrics Revenue { get; set; } = new();

        /// <summary>
        /// Gets or sets the cost metrics included in the report.
        /// </summary>
        public CostMetrics Costs { get; set; } = new();

        /// <summary>
        /// Gets or sets the profitability metrics included in the report.
        /// </summary>
        public ProfitabilityMetrics Profitability { get; set; } = new();

        /// <summary>
        /// Gets or sets the financial breakdown by project.
        /// </summary>
        public List<ProjectFinancials> ProjectBreakdown { get; set; } = new();

        /// <summary>
        /// Gets or sets the financial breakdown by client.
        /// </summary>
        public List<ClientFinancials> ClientBreakdown { get; set; } = new();

        /// <summary>
        /// Gets or sets the financial breakdown by agent.
        /// </summary>
        public List<AgentFinancials> AgentBreakdown { get; set; } = new();

        /// <summary>
        /// Gets or sets the cash flow metrics included in the report.
        /// </summary>
        public CashFlowMetrics CashFlow { get; set; } = new();

        /// <summary>
        /// Gets or sets the list of financial trends included in the report.
        /// </summary>
        public List<FinancialTrend> Trends { get; set; } = new();

        /// <summary>
        /// Gets or sets the identifier of the agent who generated the report.
        /// </summary>
        public string GeneratedByAgentId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date and time when the report was generated.
        /// </summary>
        public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the binary content of the generated report (e.g., PDF).
        /// </summary>
        public byte[] ReportContent { get; set; } = Array.Empty<byte>();
    }
}
