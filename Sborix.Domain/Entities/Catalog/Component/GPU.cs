namespace Entities.Catalog
{
    using Entities.Deal;
    using Review = Entities.Review.Review;

    public class GPU : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int? GuaranteeMonth { get; set; }
        public int NumberAvailable { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Description { get; set; }

        // характеристики видеокарты
        public int VramGb { get; set; }
        public decimal CoreClockMHz { get; set; }
        public int TdpWatts { get; set; }
        public int LengthMm { get; set; }

        public ICollection<Media> Media { get; set; } = [];       // фото, 3D
        public ICollection<Booking> Bookings { get; set; } = [];  // брони
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
