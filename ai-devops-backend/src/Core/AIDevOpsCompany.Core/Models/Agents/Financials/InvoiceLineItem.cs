namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents a line item in an invoice, including details about the service or product.
    /// </summary>
    public class InvoiceLineItem
    {
        /// <summary>
        /// Gets or sets the unique identifier for the line item.
        /// </summary>
        public string LineItemId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the line item.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the line item.
        /// </summary>
        public LineItemType Type { get; set; }

        /// <summary>
        /// Gets or sets the quantity for the line item.
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit of measurement for the line item.
        /// </summary>
        public string Unit { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unit price for the line item.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the discount applied to the line item.
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or sets the tax rate applied to the line item.
        /// </summary>
        public decimal TaxRate { get; set; }

        /// <summary>
        /// Gets or sets the total amount for the line item.
        /// </summary>
        public decimal LineTotal { get; set; }

        /// <summary>
        /// Gets or sets the category of the line item.
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the project phase associated with the line item.
        /// </summary>
        public string ProjectPhase { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the service date for the line item, if applicable.
        /// </summary>
        public DateTime? ServiceDate { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier associated with the line item.
        /// </summary>
        public string ResourceId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the agent identifier associated with the line item.
        /// </summary>
        public string AgentId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets additional metadata for the line item.
        /// </summary>
        public Dictionary<string, object> Metadata { get; set; } = new();
    }
}
