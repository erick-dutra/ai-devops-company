namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Possible statuses for a payment.
    /// </summary>
    public enum PaymentStatus
    {
        /// <summary>Payment is pending.</summary>
        Pending,
        /// <summary>Payment is being processed.</summary>
        Processing,
        /// <summary>Payment completed successfully.</summary>
        Completed,
        /// <summary>Payment failed.</summary>
        Failed,
        /// <summary>Payment was cancelled.</summary>
        Cancelled,
        /// <summary>Payment was refunded.</summary>
        Refunded,
        /// <summary>Payment is disputed.</summary>
        Disputed
    }
}
