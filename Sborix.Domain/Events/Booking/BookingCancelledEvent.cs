namespace Entities.Events.Booking
{
    /// <summary>Событие: бронь отменена.</summary>
    public class BookingCancelledEvent : DomainEventBase
    {
        public BookingCancelledEvent(Guid bookingId, Guid userId, string? reason = null)
        {
            BookingId = bookingId;
            UserId = userId;
            Reason = reason;
        }

        public Guid BookingId { get; }
        public Guid UserId { get; }
        public string? Reason { get; }
    }
}