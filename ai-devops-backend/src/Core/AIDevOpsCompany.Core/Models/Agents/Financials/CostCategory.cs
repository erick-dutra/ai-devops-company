namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Specifies the category of a cost in the financial system.
    /// </summary>
    public enum CostCategory
    {
        /// <summary>Infrastructure-related costs.</summary>
        Infrastructure,
        /// <summary>Development-related costs.</summary>
        Development,
        /// <summary>Testing-related costs.</summary>
        Testing,
        /// <summary>Deployment-related costs.</summary>
        Deployment,
        /// <summary>Monitoring-related costs.</summary>
        Monitoring,
        /// <summary>Support-related costs.</summary>
        Support,
        /// <summary>Licensing costs.</summary>
        Licensing,
        /// <summary>Training costs.</summary>
        Training,
        /// <summary>Administrative costs.</summary>
        Administration,
        /// <summary>Marketing costs.</summary>
        Marketing,
        /// <summary>Other miscellaneous costs.</summary>
        Other
    }
}
