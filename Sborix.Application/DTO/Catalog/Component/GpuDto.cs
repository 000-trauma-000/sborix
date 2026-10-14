namespace Sborix.Application.DTO.Catalog
{
    public class GpuDto : ComponentDto
    {
        public int VramGb { get; set; }
        public decimal CoreClockMHz { get; set; }
        public int TdpWatts { get; set; }
        public int LengthMm { get; set; }
    }

    public class CreateGpuDto : CreateComponentDto
    {
        public int VramGb { get; set; }
        public decimal CoreClockMHz { get; set; }
        public int TdpWatts { get; set; }
        public int LengthMm { get; set; }
    }
}