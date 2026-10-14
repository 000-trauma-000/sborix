namespace Entities.Deal
{
    /// <summary>Платёж по брони.</summary>
    public class Payment : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; } = null!;

        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public PaymentMethod Method { get; set; } = PaymentMethod.Card;

        public string? TransactionId { get; set; }          // id от платёжного шлюза
        public DateTime? PaidAt { get; set; }
        public string? FailureReason { get; set; }
    }
}