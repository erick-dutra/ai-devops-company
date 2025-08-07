namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Represents company information for billing and invoicing.
    /// </summary>
    public class CompanyInfo
    {
        /// <summary>
        /// Name of the company.
        /// </summary>
        public string CompanyName { get; set; } = string.Empty;
        /// <summary>
        /// Address of the company.
        /// </summary>
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// City where the company is located.
        /// </summary>
        public string City { get; set; } = string.Empty;
        /// <summary>
        /// State or province of the company.
        /// </summary>
        public string State { get; set; } = string.Empty;
        /// <summary>
        /// Postal code of the company address.
        /// </summary>
        public string PostalCode { get; set; } = string.Empty;
        /// <summary>
        /// Country where the company is registered.
        /// </summary>
        public string Country { get; set; } = string.Empty;
        /// <summary>
        /// Tax identification number.
        /// </summary>
        public string TaxId { get; set; } = string.Empty;
        /// <summary>
        /// Company email address.
        /// </summary>
        public string Email { get; set; } = string.Empty;
        /// <summary>
        /// Company phone number.
        /// </summary>
        public string Phone { get; set; } = string.Empty;
        /// <summary>
        /// Company website URL.
        /// </summary>
        public string Website { get; set; } = string.Empty;
        /// <summary>
        /// Company logo as a byte array.
        /// </summary>
        public byte[] Logo { get; set; } = Array.Empty<byte>();
    }
}
