namespace Sborix.Application.DTO.Review
{
    public class ReviewDto
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public Guid? BuildId { get; set; }
        public Guid? CpuId { get; set; }
        public Guid? GpuId { get; set; }
        public Guid? RamId { get; set; }
        public Guid? RatingId { get; set; }
    }

    public class CreateReviewDto
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public Guid? BuildId { get; set; }
        public Guid? CpuId { get; set; }
        public Guid? GpuId { get; set; }
        public Guid? RamId { get; set; }
    }
}