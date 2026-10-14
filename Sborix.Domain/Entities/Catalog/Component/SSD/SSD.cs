namespace Entities.Catalog
{
    using Entities.Deal;
    using Review = Entities.Review.Review;

    public class SSD : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int? GuaranteeMonth { get; set; }
        public int NumberAvailable { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Description { get; set; }

        // характеристики накопителя
        public int CapacityGb { get; set; }
        public string Interface { get; set; } = null!;      // SATA / NVMe PCIe 4.0
        public int ReadSpeedMbps { get; set; }
        public int WriteSpeedMbps { get; set; }
        public string FormFactor { get; set; } = null!;     // M.2 / 2.5"

        public ICollection<Media> Media { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
