namespace Entities.DomainExceptions
{
    /// <summary>Пользователь не авторизован (нет токена или токен невалиден).</summary>
    public class UnauthorizedException : DomainException
    {
        public UnauthorizedException(string message = "Пользователь не авторизован.")
            : base(message)
        {
        }
    }
}