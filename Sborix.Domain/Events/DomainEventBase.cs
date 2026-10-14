namespace Entities.Events
{
    /// <summary>Базовый класс доменных событий — EventId и дата заполняются автоматически.</summary>
    public abstract class DomainEventBase : IDomainEvent
    {
        public Guid EventId { get; } = Guid.NewGuid();

        public DateTime OccurredOnUtc { get; } = DateTime.UtcNow;
    }
}