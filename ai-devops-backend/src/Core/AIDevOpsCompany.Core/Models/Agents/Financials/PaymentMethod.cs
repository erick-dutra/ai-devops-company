namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a payment method with details and preferences.
    /// </summary>
    public class PaymentMethod
    {
        /// <summary>
        /// Gets or sets the type of payment method.
        /// </summary>
        public PaymentMethodType Type { get; set; }

        /// <summary>
        /// Gets or sets the details of the payment method (e.g., account number, card info).
        /// </summary>
        public string Details { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether this is the preferred payment method.
        /// </summary>
        public bool IsPreferred { get; set; }

        /// <summary>
        /// Gets or sets the processing fee for using this payment method.
        /// </summary>
        public decimal ProcessingFee { get; set; }
    }
}
