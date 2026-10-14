namespace Sborix.Application.DTO.Review
{
    public class RatingDto
    {
        public Guid Id { get; set; }
        public int Value { get; set; }
        public Guid UserId { get; set; }
        public Guid? BuildId { get; set; }
        public Guid? CpuId { get; set; }
        public Guid? GpuId { get; set; }
        public Guid? RamId { get; set; }
    }

    public class CreateRatingDto
    {
        public int Value { get; set; }
        public Guid? BuildId { get; set; }
        public Guid? CpuId { get; set; }
        public Guid? GpuId { get; set; }
        public Guid? RamId { get; set; }
    }
}