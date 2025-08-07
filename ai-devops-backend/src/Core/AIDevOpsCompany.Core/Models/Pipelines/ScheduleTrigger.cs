namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Represents a trigger based on a schedule (cron expression).
    /// </summary>
    public class ScheduleTrigger
    {
        /// <summary>
        /// Cron expression for the schedule.
        /// </summary>
        public string CronExpression { get; set; } = string.Empty;
        /// <summary>
        /// Branches to trigger on.
        /// </summary>
        public List<string> Branches { get; set; } = new();
        /// <summary>
        /// Trigger only if changes are detected.
        /// </summary>
        public bool OnlyIfChanged { get; set; }
        /// <summary>
        /// Time zone for the schedule.
        /// </summary>
        public string TimeZone { get; set; } = "UTC";
    }
}
