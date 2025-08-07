namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents a lesson learned from an incident, including description, category, and applicability.
    /// </summary>
    public class LessonsLearned
    {
        /// <summary>
        /// Gets or sets the unique identifier for the lesson learned.
        /// </summary>
        public string LessonId { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the title of the lesson learned.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description of the lesson learned.
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the category of the lesson learned.
        /// </summary>
        public LessonCategory Category { get; set; }
        /// <summary>
        /// Gets or sets the applicability of the lesson learned.
        /// </summary>
        public string Applicability { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the related processes for the lesson.
        /// </summary>
        public List<string> RelatedProcesses { get; set; } = new();
        /// <summary>
        /// Gets or sets the related systems for the lesson.
        /// </summary>
        public List<string> RelatedSystems { get; set; } = new();
        /// <summary>
        /// Gets or sets a value indicating whether the lesson has been shared.
        /// </summary>
        public bool Shared { get; set; }
        /// <summary>
        /// Gets or sets the date and time when the lesson was shared.
        /// </summary>
        public DateTime SharedAt { get; set; }
    }
}
