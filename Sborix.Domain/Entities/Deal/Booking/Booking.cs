using Entities.Catalog;

namespace Entities.Deal
{
    /// <summary>Бронь: сборки целиком или отдельных компонентов.</summary>
    public class Booking : BaseEntity
    {
        public Guid UserId { get; set; }      // кто забронировал
        public User User { get; set; } = null!;

        // что бронируем
        public Guid? BuildId { get; set; }
        public Build? Build { get; set; }
        public Guid? CpuId { get; set; }
        public CPU? Cpu { get; set; }
        public Guid? GpuId { get; set; }
        public GPU? Gpu { get; set; }
        public Guid? RamId { get; set; }
        public RAM? Ram { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public BookingStatus Status { get; set; } = BookingStatus.Pending;
        public decimal TotalPrice { get; set; }
        public string? Comment { get; set; }

        public ICollection<BookingItem> Items { get; set; } = [];
        public ICollection<Payment> Payments { get; set; } = [];
    }
}