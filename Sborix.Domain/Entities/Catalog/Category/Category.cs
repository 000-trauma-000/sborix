namespace Entities.Catalog
{
    /// <summary>Категория каталога (древовидная).</summary>
    public class Category : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

        public Guid? ParentId { get; set; }                 // для вложенных категорий
        public Category? Parent { get; set; }
        public ICollection<Category> Children { get; set; } = [];
    }
}