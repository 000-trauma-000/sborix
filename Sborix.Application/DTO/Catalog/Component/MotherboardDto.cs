namespace Sborix.Application.DTO.Catalog
{
    public class MotherboardDto : ComponentDto
    {
        public string Socket { get; set; } = null!;
        public string Chipset { get; set; } = null!;
        public string FormFactor { get; set; } = null!;
        public string MemoryType { get; set; } = null!;
        public int MemorySlots { get; set; }
    }

    public class CreateMotherboardDto : CreateComponentDto
    {
        public string Socket { get; set; } = null!;
        public string Chipset { get; set; } = null!;
        public string FormFactor { get; set; } = null!;
        public string MemoryType { get; set; } = null!;
        public int MemorySlots { get; set; }
    }
}