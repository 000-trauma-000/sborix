using Entities.Catalog;

namespace Sborix.Application.DTO.Catalog
{
    public class MediaDto
    {
        public Guid Id { get; set; }
        public string Url { get; set; } = null!;
        public MediaType Type { get; set; }
        public string? AltText { get; set; }
        public int SortOrder { get; set; }
        public Guid? BuildId { get; set; }
        public Guid? CpuId { get; set; }
        public Guid? GpuId { get; set; }
        public Guid? RamId { get; set; }
    }
}