namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Specifies the type of a cost (e.g., fixed, variable, one-time, recurring, usage).
    /// </summary>
    public enum CostType
    {
        /// <summary>Fixed cost.</summary>
        Fixed,
        /// <summary>Variable cost.</summary>
        Variable,
        /// <summary>One-time cost.</summary>
        OneTime,
        /// <summary>Recurring cost.</summary>
        Recurring,
        /// <summary>Usage-based cost.</summary>
        Usage
    }
}
