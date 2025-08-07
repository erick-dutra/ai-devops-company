namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents efficiency-related metrics for an agent's performance.
    /// </summary>
    public class EfficiencyMetrics
    {
        /// <summary>
        /// Gets or sets the productivity score.
        /// </summary>
        public double ProductivityScore { get; set; }

        /// <summary>
        /// Gets or sets the speed score.
        /// </summary>
        public double SpeedScore { get; set; }

        /// <summary>
        /// Gets or sets the resource utilization score.
        /// </summary>
        public double ResourceUtilizationScore { get; set; }

        /// <summary>
        /// Gets or sets the cost efficiency score.
        /// </summary>
        public double CostEfficiencyScore { get; set; }

        /// <summary>
        /// Gets or sets the average response time.
        /// </summary>
        public TimeSpan AverageResponseTime { get; set; }

        /// <summary>
        /// Gets or sets the average processing time.
        /// </summary>
        public TimeSpan AverageProcessingTime { get; set; }

        /// <summary>
        /// Gets or sets the throughput rate.
        /// </summary>
        public double ThroughputRate { get; set; }

        /// <summary>
        /// Gets or sets the automation rate.
        /// </summary>
        public double AutomationRate { get; set; }

        /// <summary>
        /// Gets or sets the number of process optimizations suggested.
        /// </summary>
        public int ProcessOptimizationsSuggested { get; set; }

        /// <summary>
        /// Gets or sets the number of process optimizations implemented.
        /// </summary>
        public int ProcessOptimizationsImplemented { get; set; }

        /// <summary>
        /// Gets or sets the cost savings generated.
        /// </summary>
        public decimal CostSavingsGenerated { get; set; }

        /// <summary>
        /// Gets or sets the value created.
        /// </summary>
        public decimal ValueCreated { get; set; }
    }
}
