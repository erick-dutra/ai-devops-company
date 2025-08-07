namespace AIDevOpsCompany.Core.Models.Incidents
{
    public enum IncidentEventType
    {
        Detected,
        Acknowledged,
        InvestigationStarted,
        MitigationStarted,
        Mitigated,
        Escalated,
        Resolved,
        Closed,
        Reopened,
        StatusUpdate,
        ActionTaken
    }
}
