namespace AIDevOpsCompany.Core.Models.Requirements
{
    /// <summary>
    /// Specifies the type of a requirement.
    /// </summary>
    public enum RequirementType
    {
        /// <summary>Functional requirement.</summary>
        Functional,
        /// <summary>Non-functional requirement.</summary>
        NonFunctional,
        /// <summary>Business requirement.</summary>
        Business,
        /// <summary>Technical requirement.</summary>
        Technical,
        /// <summary>Constraint requirement.</summary>
        Constraint,
        /// <summary>Assumption requirement.</summary>
        Assumption
    }
}
