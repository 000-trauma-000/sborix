namespace Sborix.Application.DTO.Catalog
{
    public class BrandDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string LogoURL { get; set; } = null!;
        public string? Description { get; set; }
        public string Country { get; set; } = null!;
        public string WebsiteBrand { get; set; } = null!;
        public string[] Product { get; set; } = [];
    }

    public class CreateBrandDto
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string LogoURL { get; set; } = null!;
        public string? Description { get; set; }
        public string Country { get; set; } = null!;
        public string WebsiteBrand { get; set; } = null!;
        public string[] Product { get; set; } = [];
    }
}