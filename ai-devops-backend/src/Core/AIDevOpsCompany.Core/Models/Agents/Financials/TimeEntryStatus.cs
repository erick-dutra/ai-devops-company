namespace AIDevOpsCompany.Core.Models.Agents.Financials
{
    /// <summary>
    /// Specifies the status of a time entry for billing and approval.
    /// </summary>
    public enum TimeEntryStatus
    {
        /// <summary>Time entry is in draft state.</summary>
        Draft,
        /// <summary>Time entry has been submitted for approval.</summary>
        Submitted,
        /// <summary>Time entry has been approved.</summary>
        Approved,
        /// <summary>Time entry has been rejected.</summary>
        Rejected,
        /// <summary>Time entry has been billed.</summary>
        Billed,
        /// <summary>Time entry has been paid.</summary>
        Paid
    }
}
