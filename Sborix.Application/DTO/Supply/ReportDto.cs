using Entities.Supply;

namespace Sborix.Application.DTO.Supply
{
    public class ReportDto
    {
        public Guid Id { get; set; }
        public Guid ReporterId { get; set; }
        public ReportTargetType TargetType { get; set; }
        public Guid TargetId { get; set; }
        public string Reason { get; set; } = null!;
        public string? Description { get; set; }
        public ReportStatus Status { get; set; }
        public DateTime? ResolvedAt { get; set; }
        public string? ResolutionComment { get; set; }
    }

    public class CreateReportDto
    {
        public ReportTargetType TargetType { get; set; }
        public Guid TargetId { get; set; }
        public string Reason { get; set; } = null!;
        public string? Description { get; set; }
    }
}