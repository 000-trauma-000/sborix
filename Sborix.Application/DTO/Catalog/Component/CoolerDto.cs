namespace Sborix.Application.DTO.Catalog
{
    public class CoolerDto : ComponentDto
    {
        public string Type { get; set; } = null!;
        public int TdpWatts { get; set; }
        public string? SupportedSockets { get; set; }
        public int? HeightMm { get; set; }
        public int? FanSizeMm { get; set; }
    }

    public class CreateCoolerDto : CreateComponentDto
    {
        public string Type { get; set; } = null!;
        public int TdpWatts { get; set; }
        public string? SupportedSockets { get; set; }
        public int? HeightMm { get; set; }
        public int? FanSizeMm { get; set; }
    }
}