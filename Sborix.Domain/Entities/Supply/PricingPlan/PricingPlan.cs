using Entities.Catalog;

namespace Entities.Supply
{
    /// <summary>Тарифный план аренды.</summary>
    public class PricingPlan : BaseEntity
    {
        public string Name { get; set; } = null!;           // «Сутки», «Неделя», «Месяц»
        public string? Description { get; set; }

        public decimal PricePerDay { get; set; }
        public int MinDays { get; set; } = 1;
        public int DiscountPercent { get; set; }            // скидка плана, %

        public Guid? BuildId { get; set; }                  // null — общий план для всех сборок
        public Build? Build { get; set; }

        public bool IsActive { get; set; } = true;
    }
}