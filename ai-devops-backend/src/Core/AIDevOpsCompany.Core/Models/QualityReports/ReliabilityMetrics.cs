using AIDevOpsCompany.Core.Models.Agents.Performances;

namespace AIDevOpsCompany.Core.Models.QualityReports
{
    /// <summary>
    /// Represents reliability-related metrics for quality reports, including uptime, failures, and SLA compliance.
    /// </summary>
    public class ReliabilityMetrics
    {
        /// <summary>
        /// Percentage of uptime over a given period.
        /// </summary>
        public double UptimePercentage { get; set; }
        /// <summary>
        /// Number of failures occurred in the period.
        /// </summary>
        public int FailureCount { get; set; }
        /// <summary>
        /// Mean time between failures (MTBF).
        /// </summary>
        public TimeSpan MeanTimeBetweenFailures { get; set; }
        /// <summary>
        /// Mean time to recovery (MTTR) after a failure.
        /// </summary>
        public TimeSpan MeanTimeToRecovery { get; set; }
        /// <summary>
        /// Overall availability score.
        /// </summary>
        public double AvailabilityScore { get; set; }
        /// <summary>
        /// Consistency score for system reliability.
        /// </summary>
        public double ConsistencyScore { get; set; }
        /// <summary>
        /// Predictability score for system reliability.
        /// </summary>
        public double PredictabilityScore { get; set; }
        /// <summary>
        /// Total minutes of unplanned downtime.
        /// </summary>
        public int UnplannedDowntimeMinutes { get; set; }
        /// <summary>
        /// Number of completed maintenance windows.
        /// </summary>
        public int MaintenanceWindowsCompleted { get; set; }
        /// <summary>
        /// Service Level Agreement (SLA) compliance rate.
        /// </summary>
        public double SLAComplianceRate { get; set; }
        /// <summary>
        /// List of reliability incidents that occurred.
        /// </summary>
        public List<ReliabilityIncident> Incidents { get; set; } = new();
    }
}
