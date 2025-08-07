namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Supported payment method types.
    /// </summary>
    public enum PaymentMethodType
    {
        /// <summary>Bank transfer.</summary>
        BankTransfer,
        /// <summary>Credit card.</summary>
        CreditCard,
        /// <summary>Debit card.</summary>
        DebitCard,
        /// <summary>PayPal.</summary>
        PayPal,
        /// <summary>Stripe.</summary>
        Stripe,
        /// <summary>Check.</summary>
        Check,
        /// <summary>Cash.</summary>
        Cash,
        /// <summary>Cryptocurrency.</summary>
        Cryptocurrency,
        /// <summary>Automated Clearing House.</summary>
        ACH
    }
}
