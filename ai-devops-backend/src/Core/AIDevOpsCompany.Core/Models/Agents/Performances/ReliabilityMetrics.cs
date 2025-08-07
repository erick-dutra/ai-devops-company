namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents reliability-related metrics for an agent's performance.
    /// </summary>
    public class ReliabilityMetrics
    {
        /// <summary>
        /// Gets or sets the uptime percentage.
        /// </summary>
        public double UptimePercentage { get; set; }

        /// <summary>
        /// Gets or sets the number of failures.
        /// </summary>
        public int FailureCount { get; set; }

        /// <summary>
        /// Gets or sets the mean time between failures.
        /// </summary>
        public TimeSpan MeanTimeBetweenFailures { get; set; }

        /// <summary>
        /// Gets or sets the mean time to recovery.
        /// </summary>
        public TimeSpan MeanTimeToRecovery { get; set; }

        /// <summary>
        /// Gets or sets the availability score.
        /// </summary>
        public double AvailabilityScore { get; set; }

        /// <summary>
        /// Gets or sets the consistency score.
        /// </summary>
        public double ConsistencyScore { get; set; }

        /// <summary>
        /// Gets or sets the predictability score.
        /// </summary>
        public double PredictabilityScore { get; set; }

        /// <summary>
        /// Gets or sets the number of unplanned downtime minutes.
        /// </summary>
        public int UnplannedDowntimeMinutes { get; set; }

        /// <summary>
        /// Gets or sets the number of completed maintenance windows.
        /// </summary>
        public int MaintenanceWindowsCompleted { get; set; }

        /// <summary>
        /// Gets or sets the SLA compliance rate.
        /// </summary>
        public double SLAComplianceRate { get; set; }

        /// <summary>
        /// Gets or sets the list of reliability incidents.
        /// </summary>
        public List<ReliabilityIncident> Incidents { get; set; } = new();
    }
}
