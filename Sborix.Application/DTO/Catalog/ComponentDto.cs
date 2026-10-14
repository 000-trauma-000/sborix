namespace Sborix.Application.DTO.Catalog
{
    public class ComponentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public Guid BrandId { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Description { get; set; }
        public int? GuaranteeMonth { get; set; }
        public int NumberAvailable { get; set; }
    }

    public class CreateComponentDto
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public Guid BrandId { get; set; }
        public string? Description { get; set; }
        public int? GuaranteeMonth { get; set; }
        public int NumberAvailable { get; set; }
    }
}