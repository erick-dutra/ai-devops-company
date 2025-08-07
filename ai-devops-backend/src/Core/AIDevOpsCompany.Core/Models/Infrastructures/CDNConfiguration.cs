namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the configuration settings for a Content Delivery Network (CDN).
    /// </summary>
    public class CDNConfiguration
    {
        /// <summary>
        /// Indicates whether the CDN is enabled.
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// List of origin servers for the CDN.
        /// </summary>
        public List<string> Origins { get; set; } = new();
        /// <summary>
        /// List of cache behaviors for the CDN.
        /// </summary>
        public List<string> CacheBehaviors { get; set; } = new();
        /// <summary>
        /// SSL certificate ID used for secure delivery.
        /// </summary>
        public string SslCertificateId { get; set; } = string.Empty;
        /// <summary>
        /// Indicates whether compression is enabled for CDN content.
        /// </summary>
        public bool CompressionEnabled { get; set; }
    }
}
