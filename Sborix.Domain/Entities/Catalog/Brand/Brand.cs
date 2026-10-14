namespace Entities.Catalog
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string LogoURL { get; set; } = null!;
        public string? Description { get; set; }
        public string Country { get; set; } = null!;
        public string WebsiteBrand { get; set; } = null!;
        public string[] Product { get; set; } = [];
        public string Slug { get; set; } = null!;
    }
}
