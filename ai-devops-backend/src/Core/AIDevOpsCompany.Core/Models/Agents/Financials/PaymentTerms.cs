namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents payment terms and conditions for invoices or contracts.
    /// </summary>
    public class PaymentTerms
    {
        /// <summary>
        /// Gets or sets the number of days until payment is due.
        /// </summary>
        public int DueDays { get; set; }

        /// <summary>
        /// Gets or sets the discount percentage for early payment.
        /// </summary>
        public decimal EarlyPaymentDiscount { get; set; }

        /// <summary>
        /// Gets or sets the number of days within which early payment discount applies.
        /// </summary>
        public int EarlyPaymentDays { get; set; }

        /// <summary>
        /// Gets or sets the fee applied for late payment.
        /// </summary>
        public decimal LatePaymentFee { get; set; }

        /// <summary>
        /// Gets or sets the number of grace days allowed for late payment.
        /// </summary>
        public int LatePaymentGraceDays { get; set; }

        /// <summary>
        /// Gets or sets the list of accepted payment methods.
        /// </summary>
        public List<PaymentMethod> AcceptedPaymentMethods { get; set; } = new();

        /// <summary>
        /// Gets or sets the payment instructions.
        /// </summary>
        public string PaymentInstructions { get; set; } = string.Empty;
    }
}
