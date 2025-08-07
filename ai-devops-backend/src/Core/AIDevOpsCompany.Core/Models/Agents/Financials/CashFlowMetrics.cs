namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents cash flow metrics for financial analysis.
    /// </summary>
    public class CashFlowMetrics
    {
        /// <summary>
        /// Opening balance at the start of the period.
        /// </summary>
        public decimal OpeningBalance { get; set; }
        /// <summary>
        /// Closing balance at the end of the period.
        /// </summary>
        public decimal ClosingBalance { get; set; }
        /// <summary>
        /// Total cash inflow during the period.
        /// </summary>
        public decimal CashInflow { get; set; }
        /// <summary>
        /// Total cash outflow during the period.
        /// </summary>
        public decimal CashOutflow { get; set; }
        /// <summary>
        /// Net cash flow (inflow minus outflow).
        /// </summary>
        public decimal NetCashFlow { get; set; }
        /// <summary>
        /// Accounts receivable amount.
        /// </summary>
        public decimal AccountsReceivable { get; set; }
        /// <summary>
        /// Accounts payable amount.
        /// </summary>
        public decimal AccountsPayable { get; set; }
        /// <summary>
        /// Number of days in receivables.
        /// </summary>
        public int DaysInReceivables { get; set; }
        /// <summary>
        /// Number of days in payables.
        /// </summary>
        public int DaysInPayables { get; set; }
    }
}
