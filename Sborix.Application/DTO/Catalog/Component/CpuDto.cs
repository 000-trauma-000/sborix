namespace Sborix.Application.DTO.Catalog
{
    public class CpuDto : ComponentDto
    {
        public int Cores { get; set; }
        public int Threads { get; set; }
        public decimal BaseClockGHz { get; set; }
        public decimal BoostClockGHz { get; set; }
        public int TdpWatts { get; set; }
        public string Socket { get; set; } = null!;
    }

    public class CreateCpuDto : CreateComponentDto
    {
        public int Cores { get; set; }
        public int Threads { get; set; }
        public decimal BaseClockGHz { get; set; }
        public decimal BoostClockGHz { get; set; }
        public int TdpWatts { get; set; }
        public string Socket { get; set; } = null!;
    }
}