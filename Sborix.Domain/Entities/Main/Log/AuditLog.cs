namespace Entities
{
    public class AuditLog : BaseEntity
    {
        public string Action { get; set; } = null!;
        public string? EntityType { get; set; }
        public string? EntityId { get; set; }
        public string? Payload { get; set; }

        public string Level { get; set; } = "Info";
        public string? ErrorMessage { get; set; }
        public string? TraceId { get; set; }
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
    }
}