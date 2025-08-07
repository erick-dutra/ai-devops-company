namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents the scaling policy for infrastructure resources.
    /// </summary>
    public class ScalingPolicy
    {
        /// <summary>
        /// Trigger that initiates scaling actions.
        /// </summary>
        public ScalingTrigger Trigger { get; set; }
        /// <summary>
        /// Threshold for scaling up resources.
        /// </summary>
        public double ScaleUpThreshold { get; set; }
        /// <summary>
        /// Threshold for scaling down resources.
        /// </summary>
        public double ScaleDownThreshold { get; set; }
        /// <summary>
        /// Cooldown period in minutes between scaling actions.
        /// </summary>
        public int CooldownPeriodMinutes { get; set; }
        /// <summary>
        /// Name of the metric used for scaling decisions.
        /// </summary>
        public string MetricName { get; set; } = string.Empty;
    }
}
