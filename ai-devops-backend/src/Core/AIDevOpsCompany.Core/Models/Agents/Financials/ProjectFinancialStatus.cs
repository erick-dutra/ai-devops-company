namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Specifies the financial status of a project.
    /// </summary>
    public enum ProjectFinancialStatus
    {
        /// <summary>
        /// The project is on budget.
        /// </summary>
        OnBudget,
        /// <summary>
        /// The project is over budget.
        /// </summary>
        OverBudget,
        /// <summary>
        /// The project is under budget.
        /// </summary>
        UnderBudget,
        /// <summary>
        /// The project is at financial risk.
        /// </summary>
        AtRisk,
        /// <summary>
        /// The project is completed.
        /// </summary>
        Completed
    }
}
