namespace AIDevOpsCompany.Core.Models.Incidents
{
    /// <summary>
    /// Represents an analysis of incident response timelines, including acceptability and delay reasons for each phase.
    /// </summary>
    public class TimelineAnalysis
    {
        /// <summary>
        /// Indicates if the time to detect the incident was acceptable.
        /// </summary>
        public bool TimeToDetectAcceptable { get; set; }

        /// <summary>
        /// Indicates if the time to acknowledge the incident was acceptable.
        /// </summary>
        public bool TimeToAcknowledgeAcceptable { get; set; }

        /// <summary>
        /// Indicates if the time to mitigate the incident was acceptable.
        /// </summary>
        public bool TimeToMitigateAcceptable { get; set; }

        /// <summary>
        /// Indicates if the time to resolve the incident was acceptable.
        /// </summary>
        public bool TimeToResolveAcceptable { get; set; }

        /// <summary>
        /// Reason for any delay in detection.
        /// </summary>
        public string DetectionDelayReason { get; set; } = string.Empty;

        /// <summary>
        /// Reason for any delay in acknowledgment.
        /// </summary>
        public string AcknowledgmentDelayReason { get; set; } = string.Empty;

        /// <summary>
        /// Reason for any delay in mitigation.
        /// </summary>
        public string MitigationDelayReason { get; set; } = string.Empty;

        /// <summary>
        /// Reason for any delay in resolution.
        /// </summary>
        public string ResolutionDelayReason { get; set; } = string.Empty;
    }
}
