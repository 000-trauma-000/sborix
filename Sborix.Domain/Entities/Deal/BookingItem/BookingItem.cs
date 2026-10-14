using Entities.Catalog;

namespace Entities.Deal
{
    /// <summary>Позиция брони: сборка или отдельный компонент.</summary>
    public class BookingItem : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; } = null!;

        // что именно в этой позиции
        public Guid? BuildId { get; set; }
        public Build? Build { get; set; }
        public Guid? CpuId { get; set; }
        public CPU? Cpu { get; set; }
        public Guid? GpuId { get; set; }
        public GPU? Gpu { get; set; }
        public Guid? RamId { get; set; }
        public RAM? Ram { get; set; }

        public int Quantity { get; set; } = 1;
        public decimal PricePerDay { get; set; }            // цена на момент брони
        public decimal SubTotal { get; set; }               // Quantity * PricePerDay * дни
    }
}