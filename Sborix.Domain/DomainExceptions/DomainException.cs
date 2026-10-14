namespace Entities.DomainExceptions
{
    /// <summary>
    /// Базовый класс всех доменных исключений.
    /// Наследуйте от него конкретные исключения — так их удобно ловить в API
    /// и мапить на HTTP-коды (404, 409, 400 и т.д.).
    /// </summary>
    public abstract class DomainException : Exception
    {
        protected DomainException(string message)
            : base(message)
        {
        }

        protected DomainException(string message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
