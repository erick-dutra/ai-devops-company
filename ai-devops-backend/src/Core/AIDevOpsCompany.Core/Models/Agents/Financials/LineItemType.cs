namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Specifies the type of a line item in an invoice or bill.
    /// </summary>
    public enum LineItemType
    {
        /// <summary>Service line item.</summary>
        Service,
        /// <summary>Product line item.</summary>
        Product,
        /// <summary>Expense line item.</summary>
        Expense,
        /// <summary>Discount line item.</summary>
        Discount,
        /// <summary>Tax line item.</summary>
        Tax,
        /// <summary>Fee line item.</summary>
        Fee,
        /// <summary>Subscription line item.</summary>
        Subscription,
        /// <summary>Usage-based line item.</summary>
        Usage
    }
}
