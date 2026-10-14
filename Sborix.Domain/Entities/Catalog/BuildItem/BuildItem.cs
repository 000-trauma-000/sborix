namespace Entities.Catalog
{
    public class BuildItem : BaseEntity
    {
        public Guid BuildId { get; set; }
        public Build Build { get; set; } = null!;
        public string Name { get; set; } = null!;

        // ссылки на комплектующие
        public Guid? CpuId { get; set; }
        public CPU? Cpu { get; set; }
        public Guid? GpuId { get; set; }
        public GPU? Gpu { get; set; }
        public Guid? Ram1Id { get; set; }
        public RAM? Ram1 { get; set; }
        public Guid? Ram2Id { get; set; }
        public RAM? Ram2 { get; set; }
        public Guid? SsdId { get; set; }
        public SSD? Ssd { get; set; }
        public Guid? MotherboardId { get; set; }
        public Motherboard? Motherboard { get; set; }
        public Guid? PsuId { get; set; }
        public PSU? Psu { get; set; }
        public Guid? CaseId { get; set; }
        public Case? Case { get; set; }
        public Guid? CoolerId { get; set; }
        public Cooler? Cooler { get; set; }
    }
}
