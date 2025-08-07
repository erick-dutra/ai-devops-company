namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents general performance metrics for an agent.
    /// </summary>
    public class PerformanceMetrics
    {
        /// <summary>
        /// Gets or sets the number of tasks completed.
        /// </summary>
        public int TasksCompleted { get; set; }

        /// <summary>
        /// Gets or sets the number of tasks assigned.
        /// </summary>
        public int TasksAssigned { get; set; }

        /// <summary>
        /// Gets or sets the completion rate of tasks.
        /// </summary>
        public double CompletionRate { get; set; }

        /// <summary>
        /// Gets or sets the average duration of tasks.
        /// </summary>
        public TimeSpan AverageTaskDuration { get; set; }

        /// <summary>
        /// Gets or sets the total active time spent on tasks.
        /// </summary>
        public TimeSpan TotalActiveTime { get; set; }

        /// <summary>
        /// Gets or sets the utilization rate of the agent.
        /// </summary>
        public double UtilizationRate { get; set; }

        /// <summary>
        /// Gets or sets the number of projects the agent worked on.
        /// </summary>
        public int ProjectsWorkedOn { get; set; }

        /// <summary>
        /// Gets or sets the number of projects completed by the agent.
        /// </summary>
        public int ProjectsCompleted { get; set; }

        /// <summary>
        /// Gets or sets the project success rate.
        /// </summary>
        public double ProjectSuccessRate { get; set; }

        /// <summary>
        /// Gets or sets the number of errors encountered.
        /// </summary>
        public int ErrorCount { get; set; }

        /// <summary>
        /// Gets or sets the error rate.
        /// </summary>
        public double ErrorRate { get; set; }

        /// <summary>
        /// Gets or sets the number of retries performed.
        /// </summary>
        public int RetryCount { get; set; }

        /// <summary>
        /// Gets or sets the first-time success rate.
        /// </summary>
        public double FirstTimeSuccessRate { get; set; }

        /// <summary>
        /// Gets or sets the breakdown of tasks by type.
        /// </summary>
        public Dictionary<string, int> TaskTypeBreakdown { get; set; } = new();
    }
}
