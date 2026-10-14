namespace Entities.DomainExceptions
{
    /// <summary>Конфликт состояния (например, запись изменена другим пользователем).</summary>
    public class ConflictException : DomainException
    {
        public ConflictException(string message)
            : base(message)
        {
        }
    }
}