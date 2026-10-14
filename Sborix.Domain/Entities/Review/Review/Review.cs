using Entities.Catalog;

namespace Entities.Review
{
    /// <summary>Отзыв на сборку или компонент.</summary>
    public class Review : BaseEntity
    {
        public Guid AuthorId { get; set; }                  // кто оставил
        public User Author { get; set; } = null!;

        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;

        // к чему отзыв
        public Guid? BuildId { get; set; }
        public Build? Build { get; set; }
        public Guid? CpuId { get; set; }
        public CPU? Cpu { get; set; }
        public Guid? GpuId { get; set; }
        public GPU? Gpu { get; set; }
        public Guid? RamId { get; set; }
        public RAM? Ram { get; set; }

        public Guid? RatingId { get; set; }
        public Rating? Rating { get; set; }
    }
}