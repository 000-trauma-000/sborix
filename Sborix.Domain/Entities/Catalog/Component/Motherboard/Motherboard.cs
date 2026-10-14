namespace Entities.Catalog
{
    using Entities.Deal;
    using Review = Entities.Review.Review;

    public class Motherboard : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int? GuaranteeMonth { get; set; }
        public int NumberAvailable { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Description { get; set; }

        // характеристики материнской платы
        public string Socket { get; set; } = null!;         // AM5 / LGA1700
        public string Chipset { get; set; } = null!;        // B650 / Z790
        public string FormFactor { get; set; } = null!;     // ATX / mATX / ITX
        public string MemoryType { get; set; } = null!;     // DDR4 / DDR5
        public int MemorySlots { get; set; }

        public ICollection<Media> Media { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
