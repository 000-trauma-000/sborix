namespace Sborix.Application.DTO.Catalog
{
    public class RamDto : ComponentDto
    {
        public string Type { get; set; } = null!;
        public int CapacityGb { get; set; }
        public int SpeedMHz { get; set; }
        public int Modules { get; set; }
        public string FormFactor { get; set; } = null!;
    }

    public class CreateRamDto : CreateComponentDto
    {
        public string Type { get; set; } = null!;
        public int CapacityGb { get; set; }
        public int SpeedMHz { get; set; }
        public int Modules { get; set; }
        public string FormFactor { get; set; } = null!;
    }
}