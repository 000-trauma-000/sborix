namespace Entities.Catalog
{
    /// <summary>Значение характеристики для конкретного компонента.</summary>
    public class SpecValue : BaseEntity
    {
        public Guid SpecId { get; set; }
        public Spec Spec { get; set; } = null!;

        public string Value { get; set; } = null!;

        // к какому компоненту относится значение
        public Guid? CpuId { get; set; }
        public CPU? Cpu { get; set; }
        public Guid? GpuId { get; set; }
        public GPU? Gpu { get; set; }
        public Guid? RamId { get; set; }
        public RAM? Ram { get; set; }
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