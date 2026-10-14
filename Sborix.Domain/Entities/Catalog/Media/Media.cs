namespace Entities.Catalog
{
    /// <summary>Фото / видео / 3D-модель сборки или компонента.</summary>
    public class Media : BaseEntity
    {
        public string Url { get; set; } = null!;
        public MediaType Type { get; set; } = MediaType.Image;
        public string? AltText { get; set; }
        public int SortOrder { get; set; }                  // порядок показа

        // к чему относится медиафайл
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