namespace AIDevOpsCompany.Core.Models.Incidents
{
    public class IncidentCommunication
    {
        public string CommunicationId { get; set; } = string.Empty;
        public CommunicationType Type { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public List<string> Recipients { get; set; } = new();
        public CommunicationChannel Channel { get; set; }
        public CommunicationStatus Status { get; set; } = CommunicationStatus.Draft;
        public string SentByAgentId { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? SentAt { get; set; }
        public List<CommunicationResponse> Responses { get; set; } = new();
        public bool IsAutomated { get; set; }
    }
}
