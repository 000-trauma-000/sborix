namespace Entities
{
    using Entities.Events;

    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }

        // soft delete
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }

        public DateTime UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }

        // оптимистичная блокировка (версия записи)
        public long Version { get; set; }

        public bool IsCreator { get; set; }


        // ---------- доменные события ----------
        private readonly List<IDomainEvent> _domainEvents = [];

        /// <summary>События, накопленные сущностью (публикуются при сохранении).</summary>
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);

        public void RemoveDomainEvent(IDomainEvent domainEvent) => _domainEvents.Remove(domainEvent);

        public void ClearDomainEvents() => _domainEvents.Clear();
    }
}
