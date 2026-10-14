namespace Sborix.Application.DTO.Catalog
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid? ParentId { get; set; }
        public ICollection<CategoryDto> Children { get; set; } = [];
    }

    public class CreateCategoryDto
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid? ParentId { get; set; }
    }
}