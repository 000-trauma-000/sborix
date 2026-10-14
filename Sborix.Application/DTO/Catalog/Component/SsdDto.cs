namespace Sborix.Application.DTO.Catalog
{
    public class SsdDto : ComponentDto
    {
        public int CapacityGb { get; set; }
        public string Interface { get; set; } = null!;
        public int ReadSpeedMbps { get; set; }
        public int WriteSpeedMbps { get; set; }
        public string FormFactor { get; set; } = null!;
    }

    public class CreateSsdDto : CreateComponentDto
    {
        public int CapacityGb { get; set; }
        public string Interface { get; set; } = null!;
        public int ReadSpeedMbps { get; set; }
        public int WriteSpeedMbps { get; set; }
        public string FormFactor { get; set; } = null!;
    }
}