namespace Entities.Events
{
    /// <summary>
    /// Доменное событие — факт о том, что в домене что-то произошло
    /// (например, «бронь подтверждена», «пользователь зарегистрирован»).
    /// Обработчики подписываются на события в слое Application.
    /// </summary>
    public interface IDomainEvent
    {
        Guid EventId { get; }
        DateTime OccurredOnUtc { get; }
    }
}