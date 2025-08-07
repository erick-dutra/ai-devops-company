namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents a rule for triggering alerts based on monitored metrics and conditions.
    /// </summary>
    public class AlertRule
    {
        /// <summary>
        /// Unique identifier for the alert rule.
        /// </summary>
        public string RuleId { get; set; } = string.Empty;
        /// <summary>
        /// Name of the alert rule.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Name of the metric being monitored.
        /// </summary>
        public string MetricName { get; set; } = string.Empty;
        /// <summary>
        /// Condition under which the alert is triggered.
        /// </summary>
        public AlertCondition Condition { get; set; }
        /// <summary>
        /// Threshold value for the alert condition.
        /// </summary>
        public double Threshold { get; set; }
        /// <summary>
        /// Evaluation period in minutes for the alert rule.
        /// </summary>
        public int EvaluationPeriodMinutes { get; set; }
        /// <summary>
        /// List of notification channels to use when the alert is triggered.
        /// </summary>
        public List<string> NotificationChannels { get; set; } = new();
        /// <summary>
        /// Severity level of the alert.
        /// </summary>
        public AlertSeverity Severity { get; set; }
    }
}
