namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the possible outcomes of a collaboration event.
    /// </summary>
    public enum CollaborationEventOutcome
    {
        /// <summary>
        /// The collaboration event was fully successful.
        /// </summary>
        Successful,
        /// <summary>
        /// The collaboration event was partially successful.
        /// </summary>
        PartiallySuccessful,
        /// <summary>
        /// The collaboration event was unsuccessful.
        /// </summary>
        Unsuccessful,
        /// <summary>
        /// The collaboration event is ongoing and not yet completed.
        /// </summary>
        Ongoing
    }
}
