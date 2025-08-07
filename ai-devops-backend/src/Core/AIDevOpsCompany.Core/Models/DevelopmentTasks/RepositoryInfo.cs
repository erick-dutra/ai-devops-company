namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents information about a source code repository, including URLs, branch, commit, and file changes.
    /// </summary>
    public class RepositoryInfo
    {
        /// <summary>
        /// The URL of the repository.
        /// </summary>
        public string RepositoryUrl { get; set; } = string.Empty;

        /// <summary>
        /// The name of the branch.
        /// </summary>
        public string BranchName { get; set; } = string.Empty;

        /// <summary>
        /// The hash of the commit.
        /// </summary>
        public string CommitHash { get; set; } = string.Empty;

        /// <summary>
        /// The commit message.
        /// </summary>
        public string CommitMessage { get; set; } = string.Empty;

        /// <summary>
        /// The URL of the related pull request, if any.
        /// </summary>
        public string PullRequestUrl { get; set; } = string.Empty;

        /// <summary>
        /// The list of files modified in the commit.
        /// </summary>
        public List<string> ModifiedFiles { get; set; } = new();

        /// <summary>
        /// The list of files added in the commit.
        /// </summary>
        public List<string> AddedFiles { get; set; } = new();

        /// <summary>
        /// The list of files deleted in the commit.
        /// </summary>
        public List<string> DeletedFiles { get; set; } = new();

        /// <summary>
        /// The date and time of the last commit (UTC).
        /// </summary>
        public DateTime LastCommitAt { get; set; } = DateTime.UtcNow;
    }
}
