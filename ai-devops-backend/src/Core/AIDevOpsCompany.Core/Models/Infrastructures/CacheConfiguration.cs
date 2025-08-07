namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the configuration settings for a cache in the infrastructure.
    /// </summary>
    public class CacheConfiguration
    {
        /// <summary>
        /// Type of cache being used (e.g., Redis, Memcached).
        /// </summary>
        public CacheType Type { get; set; }
        /// <summary>
        /// The node type for the cache cluster.
        /// </summary>
        public string NodeType { get; set; } = string.Empty;
        /// <summary>
        /// Number of nodes in the cache cluster.
        /// </summary>
        public int NumberOfNodes { get; set; }
        /// <summary>
        /// Indicates if cluster mode is enabled.
        /// </summary>
        public bool ClusterMode { get; set; }
        /// <summary>
        /// Version of the cache engine.
        /// </summary>
        public string Version { get; set; } = string.Empty;
    }
}
