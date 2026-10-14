namespace Entities.Supply
{
    /// <summary>Статус обработки жалобы.</summary>
    public enum ReportStatus
    {
        New = 0,
        InReview = 1,
        Resolved = 2,
        Rejected = 3
    }
}