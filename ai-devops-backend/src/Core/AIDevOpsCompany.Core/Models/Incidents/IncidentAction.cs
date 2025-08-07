namespace AIDevOpsCompany.Core.Models.Incidents
{
    public class IncidentAction
    {
        public string ActionId { get; set; } = string.Empty;
        public IncidentActionType Type { get; set; }
        public string Description { get; set; } = string.Empty;
        public IncidentActionStatus Status { get; set; } = IncidentActionStatus.Pending;
        public string AssignedToAgentId { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public TimeSpan EstimatedDuration { get; set; }
        public TimeSpan ActualDuration { get; set; }
        public string Result { get; set; } = string.Empty;
        public List<string> Dependencies { get; set; } = new();
        public bool IsAutomated { get; set; }
        public Dictionary<string, object> Parameters { get; set; } = new();
    }
}
