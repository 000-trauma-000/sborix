namespace Sborix.Application.DTO.Catalog
{
    public class CaseDto : ComponentDto
    {
        public string FormFactor { get; set; } = null!;
        public int? MaxGpuLengthMm { get; set; }
        public int? MaxCoolerHeightMm { get; set; }
        public string? Color { get; set; }
    }

    public class CreateCaseDto : CreateComponentDto
    {
        public string FormFactor { get; set; } = null!;
        public int? MaxGpuLengthMm { get; set; }
        public int? MaxCoolerHeightMm { get; set; }
        public string? Color { get; set; }
    }
}