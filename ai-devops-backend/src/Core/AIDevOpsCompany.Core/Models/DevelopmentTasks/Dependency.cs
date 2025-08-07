using AIDevOpsCompany.Core.Models.QualityReports;

namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a software dependency, including its name, version, type, source, license, and known vulnerabilities.
    /// </summary>
    public class Dependency
    {
        /// <summary>
        /// The name of the dependency.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The version of the dependency.
        /// </summary>
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// The type of dependency (e.g., library, framework).
        /// </summary>
        public DependencyType Type { get; set; }

        /// <summary>
        /// The source or repository of the dependency.
        /// </summary>
        public string Source { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether the dependency is required.
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// The license type of the dependency.
        /// </summary>
        public string License { get; set; } = string.Empty;

        /// <summary>
        /// The list of known security vulnerabilities for the dependency.
        /// </summary>
        public List<SecurityVulnerability> KnownVulnerabilities { get; set; } = new();
    }
}
