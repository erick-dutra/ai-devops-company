namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Specifies the type of class in the codebase, such as entity, service, controller, or utility.
    /// </summary>
    public enum ClassType
    {
        /// <summary>
        /// Entity class type.
        /// </summary>
        Entity,
        /// <summary>
        /// Service class type.
        /// </summary>
        Service,
        /// <summary>
        /// Controller class type.
        /// </summary>
        Controller,
        /// <summary>
        /// Repository class type.
        /// </summary>
        Repository,
        /// <summary>
        /// Data Transfer Object (DTO) class type.
        /// </summary>
        DTO,
        /// <summary>
        /// Utility class type.
        /// </summary>
        Utility,
        /// <summary>
        /// Interface type.
        /// </summary>
        Interface,
        /// <summary>
        /// Abstract class type.
        /// </summary>
        Abstract,
        /// <summary>
        /// Enum type.
        /// </summary>
        Enum
    }
}
