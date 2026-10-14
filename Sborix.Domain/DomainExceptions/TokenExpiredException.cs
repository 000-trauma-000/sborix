namespace Entities.DomainExceptions
{
    /// <summary>Срок действия токена истёк — нужен refresh token.</summary>
    public class TokenExpiredException : DomainException
    {
        public TokenExpiredException(string message = "Срок действия токена истёк.")
            : base(message)
        {
        }
    }
}