namespace Entities.Catalog
{
    using Entities.Deal;
    using Review = Entities.Review.Review;

    public class RAM : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int? GuaranteeMonth { get; set; }
        public int NumberAvailable { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Description { get; set; }

        // характеристики оперативной памяти
        public string Type { get; set; } = null!;         // DDR4 / DDR5
        public int CapacityGb { get; set; }
        public int SpeedMHz { get; set; }
        public int Modules { get; set; } = 1;             // количество планок в комплекте
        public string FormFactor { get; set; } = null!;   // DIMM / SO-DIMM

        public ICollection<Media> Media { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
