namespace Entities.Events.Booking
{
    /// <summary>Событие: бронь подтверждена.</summary>
    public class BookingConfirmedEvent : DomainEventBase
    {
        public BookingConfirmedEvent(Guid bookingId, Guid userId)
        {
            BookingId = bookingId;
            UserId = userId;
        }

        public Guid BookingId { get; }
        public Guid UserId { get; }
    }
}