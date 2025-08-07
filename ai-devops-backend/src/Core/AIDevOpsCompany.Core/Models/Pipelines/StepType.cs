namespace AIDevOpsCompany.Core.Models.Pipelines
{
    /// <summary>
    /// Defines the types of steps that can be executed in a pipeline job.
    /// </summary>
    public enum StepType
    {
        /// <summary>
        /// Executes a script.
        /// </summary>
        Script,
        /// <summary>
        /// Executes a predefined task.
        /// </summary>
        Task,
        /// <summary>
        /// Runs a command.
        /// </summary>
        Command,
        /// <summary>
        /// Runs a PowerShell script.
        /// </summary>
        PowerShell,
        /// <summary>
        /// Runs a Bash script.
        /// </summary>
        Bash,
        /// <summary>
        /// Executes a Docker container.
        /// </summary>
        Docker,
        /// <summary>
        /// Executes a Kubernetes job.
        /// </summary>
        Kubernetes,
        /// <summary>
        /// Custom step type.
        /// </summary>
        Custom
    }
}
