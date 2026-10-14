namespace Entities.Catalog
{
    /// <summary>Характеристика (спецификация): «Объём памяти», «TDP» и т.п.</summary>
    public class Spec : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Unit { get; set; }                   // «ГБ», «Вт», «МГц»

        public Guid? CategoryId { get; set; }               // к какой категории относится
        public Category? Category { get; set; }

        public ICollection<SpecValue> Values { get; set; } = [];
    }
}