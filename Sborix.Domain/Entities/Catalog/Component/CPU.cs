namespace Entities.Catalog
{
    using Entities.Deal;
    using Review = Entities.Review.Review;

    public class CPU : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public string? Description { get; set; }
        public int? GuaranteeMonth { get; set; }
        public int NumberAvailable { get; set; }

        // характеристики процессора
        public int Cores { get; set; }
        public int Threads { get; set; }
        public decimal BaseClockGHz { get; set; }
        public decimal BoostClockGHz { get; set; }
        public int TdpWatts { get; set; }
        public string Socket { get; set; } = null!;

        public ICollection<Media> Media { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
