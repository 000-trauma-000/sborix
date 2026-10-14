using Entities.Catalog;

namespace Entities.Supply
{
    /// <summary>Доступность сборки на период (календарь аренды).</summary>
    public class BuildAvailability : BaseEntity
    {
        public Guid BuildId { get; set; }
        public Build Build { get; set; } = null!;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsAvailable { get; set; }
        public decimal? PricePerDay { get; set; }           // индивидуальная цена на период
        public string? Note { get; set; }
    }
}