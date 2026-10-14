using Entities.Catalog;

namespace Sborix.Application.DTO.Catalog
{
    public class BuildDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Description { get; set; }
        public Guid OwnerId { get; set; }
        public decimal PricePerDay { get; set; }
        public BuildStatus Status { get; set; }
        public DateTime? PublishedAt { get; set; }
        public ICollection<BuildItemDto> Items { get; set; } = [];
        public ICollection<MediaDto> Media { get; set; } = [];
    }

    public class CreateBuildDto
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Description { get; set; }
        public decimal PricePerDay { get; set; }
        public ICollection<CreateBuildItemDto> Items { get; set; } = [];
    }

    public class CreateBuildItemDto
    {
        public string Name { get; set; } = null!;
        public Guid? CpuId { get; set; }
        public Guid? GpuId { get; set; }
        public Guid? Ram1Id { get; set; }
        public Guid? Ram2Id { get; set; }
        public Guid? SsdId { get; set; }
        public Guid? MotherboardId { get; set; }
        public Guid? PsuId { get; set; }
        public Guid? CaseId { get; set; }
        public Guid? CoolerId { get; set; }
    }
}