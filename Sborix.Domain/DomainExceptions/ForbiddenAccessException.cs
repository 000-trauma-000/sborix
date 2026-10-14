namespace Entities.DomainExceptions
{
    /// <summary>Пользователь авторизован, но у него нет прав на это действие.</summary>
    public class ForbiddenAccessException : DomainException
    {
        public ForbiddenAccessException(string message = "Доступ запрещён.")
            : base(message)
        {
        }
    }
}