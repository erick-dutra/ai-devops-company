namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Specifies the frequency at which billing occurs for financial transactions.
    /// </summary>
    public enum BillingFrequency
    {
        /// <summary>One-time billing.</summary>
        OneTime,
        /// <summary>Weekly billing.</summary>
        Weekly,
        /// <summary>Monthly billing.</summary>
        Monthly,
        /// <summary>Quarterly billing.</summary>
        Quarterly,
        /// <summary>Semi-annual billing.</summary>
        SemiAnnually,
        /// <summary>Annual billing.</summary>
        Annually,
        /// <summary>Custom billing frequency.</summary>
        Custom
    }
}
