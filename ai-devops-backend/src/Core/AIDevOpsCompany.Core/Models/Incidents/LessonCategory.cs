namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Specifies the category of a lesson learned from an incident.
    /// </summary>
    public enum LessonCategory
    {
        /// <summary>Technical-related lesson.</summary>
        Technical,
        /// <summary>Process-related lesson.</summary>
        Process,
        /// <summary>Communication-related lesson.</summary>
        Communication,
        /// <summary>Monitoring-related lesson.</summary>
        Monitoring,
        /// <summary>Response-related lesson.</summary>
        Response,
        /// <summary>Prevention-related lesson.</summary>
        Prevention,
        /// <summary>Training-related lesson.</summary>
        Training,
        /// <summary>Tooling-related lesson.</summary>
        Tooling
    }
}
