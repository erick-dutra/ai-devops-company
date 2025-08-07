namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Specifies the condition under which an alert is triggered in the infrastructure monitoring system.
    /// </summary>
    public enum AlertCondition
    {
        /// <summary>
        /// The monitored value is greater than the threshold.
        /// </summary>
        GreaterThan,
        /// <summary>
        /// The monitored value is less than the threshold.
        /// </summary>
        LessThan,
        /// <summary>
        /// The monitored value is equal to the threshold.
        /// </summary>
        Equal,
        /// <summary>
        /// The monitored value is not equal to the threshold.
        /// </summary>
        NotEqual,
        /// <summary>
        /// The monitored value is greater than or equal to the threshold.
        /// </summary>
        GreaterThanOrEqual,
        /// <summary>
        /// The monitored value is less than or equal to the threshold.
        /// </summary>
        LessThanOrEqual
    }
}
