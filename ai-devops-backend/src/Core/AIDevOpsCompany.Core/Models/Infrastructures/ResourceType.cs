namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the type of resource in the infrastructure.
    /// </summary>
    public enum ResourceType
    {
        /// <summary>Virtual machine resource.</summary>
        VirtualMachine,
        /// <summary>Container resource.</summary>
        Container,
        /// <summary>Database resource.</summary>
        Database,
        /// <summary>Load balancer resource.</summary>
        LoadBalancer,
        /// <summary>Storage resource.</summary>
        Storage,
        /// <summary>Network resource.</summary>
        Network,
        /// <summary>Cache resource.</summary>
        Cache,
        /// <summary>Content Delivery Network resource.</summary>
        CDN,
        /// <summary>Serverless function resource.</summary>
        Function,
        /// <summary>Queue resource.</summary>
        Queue,
        /// <summary>Topic resource.</summary>
        Topic
    }
}
