namespace Sborix.Application.DTO.Catalog
{
    public class PsuDto : ComponentDto
    {
        public int PowerWatts { get; set; }
        public string? Efficiency { get; set; }
        public string FormFactor { get; set; } = null!;
        public bool IsModular { get; set; }
    }

    public class CreatePsuDto : CreateComponentDto
    {
        public int PowerWatts { get; set; }
        public string? Efficiency { get; set; }
        public string FormFactor { get; set; } = null!;
        public bool IsModular { get; set; }
    }
}