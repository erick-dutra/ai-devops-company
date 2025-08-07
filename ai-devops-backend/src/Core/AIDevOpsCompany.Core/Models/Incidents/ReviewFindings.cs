namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents the findings from a post-incident review, including analysis, root causes, and process gaps.
    /// </summary>
    public class ReviewFindings
    {
        /// <summary>
        /// Gets or sets the description of what went well during the incident response.
        /// </summary>
        public string WhatWentWell { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description of what went poorly during the incident response.
        /// </summary>
        public string WhatWentPoorly { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the description of what could be improved in future incidents.
        /// </summary>
        public string WhatCouldBeImproved { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the list of root causes identified for the incident.
        /// </summary>
        public List<string> RootCauses { get; set; } = new();
        /// <summary>
        /// Gets or sets the list of contributing factors identified for the incident.
        /// </summary>
        public List<string> ContributingFactors { get; set; } = new();
        /// <summary>
        /// Gets or sets the analysis of the incident timeline.
        /// </summary>
        public TimelineAnalysis TimelineAnalysis { get; set; } = new();
        /// <summary>
        /// Gets or sets the list of process gaps identified during the review.
        /// </summary>
        public List<ProcessGap> ProcessGaps { get; set; } = new();
    }
}
