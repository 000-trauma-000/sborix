using Entities.Catalog;

namespace Entities.Review
{
    /// <summary>Оценка (1–5) на сборку или компонент.</summary>
    public class Rating : BaseEntity
    {
        public int Value { get; set; }                      // 1–5

        public Guid UserId { get; set; }                    // кто оценил
        public User User { get; set; } = null!;

        // что оценили
        public Guid? BuildId { get; set; }
        public Build? Build { get; set; }
        public Guid? CpuId { get; set; }
        public CPU? Cpu { get; set; }
        public Guid? GpuId { get; set; }
        public GPU? Gpu { get; set; }
        public Guid? RamId { get; set; }
        public RAM? Ram { get; set; }
    }
}