namespace AIDevOpsCompany.Core.Models.Agents.Performances
{
    /// <summary>
    /// Specifies the type of a quality assessment.
    /// </summary>
    public enum QualityAssessmentType
    {
        /// <summary>
        /// Assessment of code quality.
        /// </summary>
        Code,
        /// <summary>
        /// Assessment of documentation quality.
        /// </summary>
        Documentation,
        /// <summary>
        /// Assessment of testing quality.
        /// </summary>
        Testing,
        /// <summary>
        /// Assessment of security quality.
        /// </summary>
        Security,
        /// <summary>
        /// Assessment of performance quality.
        /// </summary>
        Performance,
        /// <summary>
        /// Assessment of usability quality.
        /// </summary>
        Usability,
        /// <summary>
        /// Overall quality assessment.
        /// </summary>
        Overall
    }
}
