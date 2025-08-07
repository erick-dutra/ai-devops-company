namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Possible statuses for an invoice.
    /// </summary>
    public enum InvoiceStatus
    {
        /// <summary>Invoice is a draft.</summary>
        Draft,
        /// <summary>Invoice has been sent to the client.</summary>
        Sent,
        /// <summary>Invoice has been viewed by the client.</summary>
        Viewed,
        /// <summary>Invoice is partially paid.</summary>
        PartiallyPaid,
        /// <summary>Invoice is fully paid.</summary>
        Paid,
        /// <summary>Invoice is overdue.</summary>
        Overdue,
        /// <summary>Invoice is cancelled.</summary>
        Cancelled,
        /// <summary>Invoice is refunded.</summary>
        Refunded
    }
}
