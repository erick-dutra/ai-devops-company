namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Defines the types of actions that can be taken as part of an incident resolution.
    /// </summary>
    public enum ResolutionActionType
    {
        /// <summary>
        /// Code change was performed as a resolution action.
        /// </summary>
        CodeChange,
        /// <summary>
        /// Configuration change was performed as a resolution action.
        /// </summary>
        ConfigurationChange,
        /// <summary>
        /// Infrastructure change was performed as a resolution action.
        /// </summary>
        InfrastructureChange,
        /// <summary>
        /// Process change was performed as a resolution action.
        /// </summary>
        ProcessChange,
        /// <summary>
        /// Documentation was updated as a resolution action.
        /// </summary>
        Documentation,
        /// <summary>
        /// Training was provided as a resolution action.
        /// </summary>
        Training,
        /// <summary>
        /// Monitoring was improved as a resolution action.
        /// </summary>
        Monitoring,
        /// <summary>
        /// Testing was performed as a resolution action.
        /// </summary>
        Testing
    }
}
