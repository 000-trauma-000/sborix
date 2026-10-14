namespace Entities.Supply
{
    /// <summary>Жалоба (на сборку, компонент, пользователя или отзыв).</summary>
    public class Report : BaseEntity
    {
        public Guid ReporterId { get; set; }                // кто пожаловался
        public User Reporter { get; set; } = null!;

        public ReportTargetType TargetType { get; set; }
        public Guid TargetId { get; set; }                  // на что жалоба

        public string Reason { get; set; } = null!;
        public string? Description { get; set; }

        public ReportStatus Status { get; set; } = ReportStatus.New;
        public DateTime? ResolvedAt { get; set; }
        public string? ResolutionComment { get; set; }
    }
}