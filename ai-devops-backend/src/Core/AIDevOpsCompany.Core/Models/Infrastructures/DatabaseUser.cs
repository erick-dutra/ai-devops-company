namespace AIDevOpsCompany.Core.Models.Infrastructures
{
    /// <summary>
    /// Represents a user with access to a database, including permissions and admin status.
    /// </summary>
    public class DatabaseUser
    {
        /// <summary>
        /// Username of the database user.
        /// </summary>
        public string Username { get; set; } = string.Empty;
        /// <summary>
        /// List of permissions assigned to the user.
        /// </summary>
        public List<string> Permissions { get; set; } = new();
        /// <summary>
        /// Indicates if the user has administrative privileges.
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}
