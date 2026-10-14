namespace Entities.Catalog
{
    using Entities.Deal;
    using Review = Entities.Review.Review;

    public class Build : BaseEntity
    {
        public string Name { get; set; } = null!;           // «Игровой ПК Pro»
        public string Slug { get; set; } = null!;           // «gaming-pro»
        public string? Description { get; set; }            // описание для карточки

        public Guid OwnerId { get; set; }                   // чей ПК
        public User Owner { get; set; } = null!;

        public decimal PricePerDay { get; set; }            // 500 ₽/день
        public BuildStatus Status { get; set; }             // Draft / Published / Suspended
        public DateTime? PublishedAt { get; set; }          // когда опубликована

        public ICollection<BuildItem> Items { get; set; } = [];    // комплектующие
        public ICollection<Media> Media { get; set; } = [];        // фото, 3D
        public ICollection<Booking> Bookings { get; set; } = [];   // брони
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
