namespace Entities.Catalog
{
    using Entities.Deal;
    using Review = Entities.Review.Review;

    public class PSU : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int? GuaranteeMonth { get; set; }
        public int NumberAvailable { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Description { get; set; }

        // характеристики блока питания
        public int PowerWatts { get; set; }
        public string? Efficiency { get; set; }             // 80+ Bronze / Gold
        public string FormFactor { get; set; } = null!;     // ATX / SFX
        public bool IsModular { get; set; }

        public ICollection<Media> Media { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
