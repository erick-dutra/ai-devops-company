using AIDevOpsCompany.Core.Models.Commons;

namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a financial invoice for a project.
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Unique identifier for the invoice.
        /// </summary>
        public string InvoiceId { get; set; } = string.Empty;
        /// <summary>
        /// Related project identifier.
        /// </summary>
        public string ProjectId { get; set; } = string.Empty;
        /// <summary>
        /// Invoice number.
        /// </summary>
        public string InvoiceNumber { get; set; } = string.Empty;
        /// <summary>
        /// Client information.
        /// </summary>
        public ClientInfo ClientInfo { get; set; } = new();
        /// <summary>
        /// Issuing company information.
        /// </summary>
        public CompanyInfo CompanyInfo { get; set; } = new();
        /// <summary>
        /// Current status of the invoice.
        /// </summary>
        public InvoiceStatus Status { get; set; } = InvoiceStatus.Draft;
        /// <summary>
        /// Detailed line items of the invoice.
        /// </summary>
        public List<InvoiceLineItem> LineItems { get; set; } = new();
        /// <summary>
        /// Invoice totals.
        /// </summary>
        public InvoiceTotals Totals { get; set; } = new();
        /// <summary>
        /// Payment terms.
        /// </summary>
        public PaymentTerms PaymentTerms { get; set; } = new();
        /// <summary>
        /// Payments made for this invoice.
        /// </summary>
        public List<Payment> Payments { get; set; } = new();
        /// <summary>
        /// Billing period.
        /// </summary>
        public BillingPeriod BillingPeriod { get; set; } = new();
        /// <summary>
        /// Cost breakdowns.
        /// </summary>
        public List<CostBreakdown> CostBreakdowns { get; set; } = new();
        /// <summary>
        /// Related time entries.
        /// </summary>
        public List<TimeEntry> TimeEntries { get; set; } = new();
        /// <summary>
        /// Resource usage related to the invoice.
        /// </summary>
        public List<ResourceUsage> ResourceUsages { get; set; } = new();
        /// <summary>
        /// Agent that generated the invoice.
        /// </summary>
        public string GeneratedByAgentId { get; set; } = string.Empty;
        /// <summary>
        /// Invoice creation date.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date the invoice was sent.
        /// </summary>
        public DateTime? SentAt { get; set; }
        /// <summary>
        /// Invoice due date.
        /// </summary>
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Date the invoice was paid.
        /// </summary>
        public DateTime? PaidAt { get; set; }
        /// <summary>
        /// Additional notes.
        /// </summary>
        public string Notes { get; set; } = string.Empty;
        /// <summary>
        /// Invoice attachments.
        /// </summary>
        public List<InvoiceAttachment> Attachments { get; set; } = new();
        /// <summary>
        /// Custom fields for extensibility.
        /// </summary>
        public Dictionary<string, object> CustomFields { get; set; } = new();
    }
}
