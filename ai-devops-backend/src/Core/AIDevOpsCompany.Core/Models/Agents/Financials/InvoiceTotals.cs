namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents the total amounts and currency details for an invoice.
    /// </summary>
    public class InvoiceTotals
    {
        /// <summary>
        /// Gets or sets the subtotal before discounts and taxes.
        /// </summary>
        public decimal Subtotal { get; set; }

        /// <summary>
        /// Gets or sets the total discount applied to the invoice.
        /// </summary>
        public decimal TotalDiscount { get; set; }

        /// <summary>
        /// Gets or sets the total tax applied to the invoice.
        /// </summary>
        public decimal TotalTax { get; set; }

        /// <summary>
        /// Gets or sets the total amount due for the invoice.
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Gets or sets the amount already paid.
        /// </summary>
        public decimal AmountPaid { get; set; }

        /// <summary>
        /// Gets or sets the remaining amount due.
        /// </summary>
        public decimal AmountDue { get; set; }

        /// <summary>
        /// Gets or sets the currency of the invoice.
        /// </summary>
        public string Currency { get; set; } = "USD";

        /// <summary>
        /// Gets or sets the exchange rate to the base currency.
        /// </summary>
        public decimal ExchangeRate { get; set; } = 1.0m;

        /// <summary>
        /// Gets or sets the base currency for the invoice.
        /// </summary>
        public string BaseCurrency { get; set; } = "USD";
    }
}
