namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Specifies the profitability tier classification for a client.
    /// </summary>
    public enum ClientProfitabilityTier
    {
        /// <summary>Platinum tier client.</summary>
        Platinum,
        /// <summary>Gold tier client.</summary>
        Gold,
        /// <summary>Silver tier client.</summary>
        Silver,
        /// <summary>Bronze tier client.</summary>
        Bronze,
        /// <summary>Unprofitable client.</summary>
        Unprofitable
    }
}
