namespace Entities.DomainExceptions
{
    /// <summary>Сущность не найдена (по идентификатору или значению поля).</summary>
    public class EntityNotFoundException : DomainException
    {
        public EntityNotFoundException(string entityName, object key)
            : base($"Сущность «{entityName}» с идентификатором «{key}» не найдена.")
        {
            EntityName = entityName;
            Key = key;
        }

        public EntityNotFoundException(string entityName, string fieldName, object fieldValue)
            : base($"Сущность «{entityName}» со значением «{fieldValue}» в поле «{fieldName}» не найдена.")
        {
            EntityName = entityName;
            Key = fieldValue;
        }

        public string EntityName { get; }
        public object? Key { get; }
    }
}