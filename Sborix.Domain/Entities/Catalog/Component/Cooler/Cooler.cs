namespace Entities.Catalog
{
    using Entities.Deal;
    using Review = Entities.Review.Review;

    public class Cooler : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int? GuaranteeMonth { get; set; }
        public int NumberAvailable { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Description { get; set; }

        // характеристики кулера
        public string Type { get; set; } = null!;           // Air / Liquid
        public int TdpWatts { get; set; }                   // какой TDP выдерживает
        public string? SupportedSockets { get; set; }
        public int? HeightMm { get; set; }
        public int? FanSizeMm { get; set; }

        public ICollection<Media> Media { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
