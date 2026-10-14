namespace Sborix.Application.DTO.Supply
{
    public class PricingPlanDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal PricePerDay { get; set; }
        public int MinDays { get; set; }
        public int DiscountPercent { get; set; }
        public Guid? BuildId { get; set; }
        public bool IsActive { get; set; }
    }

    public class CreatePricingPlanDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal PricePerDay { get; set; }
        public int MinDays { get; set; }
        public int DiscountPercent { get; set; }
        public Guid? BuildId { get; set; }
        public bool IsActive { get; set; } = true;
    }
}