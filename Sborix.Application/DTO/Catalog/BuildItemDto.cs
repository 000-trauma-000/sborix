namespace Sborix.Application.DTO.Catalog
{
    public class BuildItemDto
    {
        public Guid Id { get; set; }
        public Guid BuildId { get; set; }
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