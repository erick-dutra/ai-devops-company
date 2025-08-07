namespace AIDevOpsCompany.Core.Models.DevelopmentTasks
{
    /// <summary>
    /// Represents a code file, including its metadata, content, type, quality metrics, and related classes and functions.
    /// </summary>
    public class CodeFile
    {
        /// <summary>
        /// The unique identifier for the file.
        /// </summary>
        public string FileId { get; set; } = string.Empty;

        /// <summary>
        /// The name of the file.
        /// </summary>
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// The path to the file in the project.
        /// </summary>
        public string FilePath { get; set; } = string.Empty;

        /// <summary>
        /// The programming language of the file.
        /// </summary>
        public string Language { get; set; } = string.Empty;

        /// <summary>
        /// The textual content of the file.
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// The binary content of the file, if applicable.
        /// </summary>
        public byte[] BinaryContent { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// The type of the file (e.g., source, config, binary).
        /// </summary>
        public FileType FileType { get; set; }

        /// <summary>
        /// The number of lines of code in the file.
        /// </summary>
        public int LinesOfCode { get; set; }

        /// <summary>
        /// The list of modules imported by the file.
        /// </summary>
        public List<string> ImportedModules { get; set; } = new();

        /// <summary>
        /// The list of functions defined in the file.
        /// </summary>
        public List<CodeFunction> Functions { get; set; } = new();

        /// <summary>
        /// The list of classes defined in the file.
        /// </summary>
        public List<CodeClass> Classes { get; set; } = new();

        /// <summary>
        /// The code quality metrics for the file.
        /// </summary>
        public CodeQualityMetrics QualityMetrics { get; set; } = new();

        /// <summary>
        /// The date and time when the file was created (UTC).
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The ID of the agent that generated the file, if applicable.
        /// </summary>
        public string GeneratedByAgentId { get; set; } = string.Empty;
    }
}
