namespace Entities.Catalog
{
    using Entities.Deal;
    using Review = Entities.Review.Review;

    public class Case : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int? GuaranteeMonth { get; set; }
        public int NumberAvailable { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Description { get; set; }

        // характеристики корпуса
        public string FormFactor { get; set; } = null!;     // Mid Tower / Full Tower
        public int? MaxGpuLengthMm { get; set; }
        public int? MaxCoolerHeightMm { get; set; }
        public string? Color { get; set; }

        public ICollection<Media> Media { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
