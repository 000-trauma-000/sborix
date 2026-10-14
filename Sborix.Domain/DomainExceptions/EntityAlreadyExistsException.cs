namespace Entities.DomainExceptions
{
    /// <summary>Попытка создать сущность с уже занятым уникальным значением (email, slug и т.п.).</summary>
    public class EntityAlreadyExistsException : DomainException
    {
        public EntityAlreadyExistsException(string entityName, string fieldName, object fieldValue)
            : base($"Сущность «{entityName}» со значением «{fieldValue}» в поле «{fieldName}» уже существует.")
        {
            EntityName = entityName;
            FieldName = fieldName;
            FieldValue = fieldValue;
        }

        public string EntityName { get; }
        public string FieldName { get; }
        public object? FieldValue { get; }
    }
}