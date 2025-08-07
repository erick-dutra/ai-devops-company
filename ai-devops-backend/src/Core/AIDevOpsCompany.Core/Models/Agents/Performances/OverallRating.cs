namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Represents the overall performance rating for an agent, including score, rating, summary, strengths, areas for improvement, recommendations, and trend information.
    /// </summary>
    public class OverallRating
    {
        /// <summary>
        /// The overall numeric score for the agent's performance.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The performance rating category for the agent.
        /// </summary>
        public PerformanceRating Rating { get; set; }

        /// <summary>
        /// A summary of the agent's overall performance.
        /// </summary>
        public string Summary { get; set; } = string.Empty;

        /// <summary>
        /// A list of the agent's key strengths.
        /// </summary>
        public List<string> Strengths { get; set; } = new();

        /// <summary>
        /// A list of areas where the agent can improve.
        /// </summary>
        public List<string> AreasForImprovement { get; set; } = new();

        /// <summary>
        /// Recommendations for the agent's future development.
        /// </summary>
        public List<string> Recommendations { get; set; } = new();

        /// <summary>
        /// The previous overall score for the agent.
        /// </summary>
        public double PreviousScore { get; set; }

        /// <summary>
        /// The change in score compared to the previous evaluation.
        /// </summary>
        public double ScoreChange { get; set; }

        /// <summary>
        /// The trend of the agent's performance over time.
        /// </summary>
        public PerformanceTrend Trend { get; set; }
    }
}
