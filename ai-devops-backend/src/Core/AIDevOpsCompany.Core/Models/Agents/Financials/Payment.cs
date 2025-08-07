namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a payment made for an invoice.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Unique identifier for the payment.
        /// </summary>
        public string PaymentId { get; set; } = string.Empty;
        /// <summary>
        /// Payment amount.
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Payment currency.
        /// </summary>
        public string Currency { get; set; } = "USD";
        /// <summary>
        /// Payment method used.
        /// </summary>
        public PaymentMethodType Method { get; set; }
        /// <summary>
        /// Payment status.
        /// </summary>
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        /// <summary>
        /// Transaction identifier in the payment processor.
        /// </summary>
        public string TransactionId { get; set; } = string.Empty;
        /// <summary>
        /// Additional payment reference.
        /// </summary>
        public string Reference { get; set; } = string.Empty;
        /// <summary>
        /// Payment date.
        /// </summary>
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Date the payment was processed.
        /// </summary>
        public DateTime? ProcessedAt { get; set; }
        /// <summary>
        /// Payment processor response.
        /// </summary>
        public string ProcessorResponse { get; set; } = string.Empty;
        /// <summary>
        /// Processing fee charged.
        /// </summary>
        public decimal ProcessingFee { get; set; }
        /// <summary>
        /// Additional payment notes.
        /// </summary>
        public string Notes { get; set; } = string.Empty;
        /// <summary>
        /// Additional processor data.
        /// </summary>
        public Dictionary<string, object> ProcessorData { get; set; } = new();
    }
}
