namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the cloud provider used for infrastructure resources.
    /// </summary>
    public enum CloudProvider
    {
        /// <summary>
        /// Amazon Web Services.
        /// </summary>
        AWS,
        /// <summary>
        /// Microsoft Azure.
        /// </summary>
        Azure,
        /// <summary>
        /// Google Cloud Platform.
        /// </summary>
        GoogleCloud,
        /// <summary>
        /// DigitalOcean cloud provider.
        /// </summary>
        DigitalOcean,
        /// <summary>
        /// Linode cloud provider.
        /// </summary>
        Linode,
        /// <summary>
        /// On-premise infrastructure.
        /// </summary>
        OnPremise
    }
}
