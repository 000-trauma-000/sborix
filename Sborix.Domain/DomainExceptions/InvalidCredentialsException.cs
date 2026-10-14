namespace Entities.DomainExceptions
{
    /// <summary>Неверный логин или пароль при входе.</summary>
    public class InvalidCredentialsException : DomainException
    {
        public InvalidCredentialsException(string message = "Неверный логин или пароль.")
            : base(message)
        {
        }
    }
}