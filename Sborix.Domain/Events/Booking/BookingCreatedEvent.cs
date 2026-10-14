namespace Entities.Events.Booking
{
    /// <summary>Событие: бронь создана.</summary>
    public class BookingCreatedEvent : DomainEventBase
    {
        public BookingCreatedEvent(Guid bookingId, Guid userId, DateTime startDate, DateTime endDate)
        {
            BookingId = bookingId;
            UserId = userId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public Guid BookingId { get; }
        public Guid UserId { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
    }
}