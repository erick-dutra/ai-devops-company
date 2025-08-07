namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the type of cache used in the infrastructure.
    /// </summary>
    public enum CacheType
    {
        /// <summary>
        /// Redis cache.
        /// </summary>
        Redis,
        /// <summary>
        /// Memcached cache.
        /// </summary>
        Memcached,
        /// <summary>
        /// AWS ElastiCache.
        /// </summary>
        ElastiCache,
        /// <summary>
        /// Azure Cache for Redis.
        /// </summary>
        AzureCache
    }
}
