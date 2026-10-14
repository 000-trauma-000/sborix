namespace Entities.Rules.User
{
    using System.Text.RegularExpressions;
    using Entities.DomainExceptions;
    using User = Entities.User; // класс User, а не пространство имён Entities.Rules.User

    /// <summary>Бизнес-правила пользователя.</summary>
    public static class UserRules
    {
        public const int MinPasswordLength = 8;
        public const int MaxUserNameLength = 50;
        public const int MaxNameLength = 50;

        private static readonly Regex EmailRegex =
            new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

        /// <summary>Email заполнен и похож на email.</summary>
        public static void EnsureEmailIsValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new DomainValidationException("Email обязателен.", nameof(User.Email));

            if (!EmailRegex.IsMatch(email))
                throw new DomainValidationException("Некорректный формат email.", nameof(User.Email));
        }

        /// <summary>Имя пользователя (логин) заполнено и не слишком длинное.</summary>
        public static void EnsureUserNameIsValid(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new DomainValidationException("Имя пользователя обязательно.", nameof(User.UserName));

            if (userName.Length > MaxUserNameLength)
                throw new DomainValidationException(
                    $"Имя пользователя не может быть длиннее {MaxUserNameLength} символов.",
                    nameof(User.UserName));
        }

        /// <summary>Пароль достаточно длинный.</summary>
        public static void EnsurePasswordIsValid(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < MinPasswordLength)
                throw new DomainValidationException(
                    $"Пароль должен содержать минимум {MinPasswordLength} символов.",
                    "Password");
        }

        /// <summary>Хеш пароля обязательно установлен.</summary>
        public static void EnsurePasswordHashIsSet(string passwordHash)
        {
            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new DomainValidationException("Хеш пароля обязателен.", nameof(User.PasswordHash));
        }

        /// <summary>Имя и фамилия не слишком длинные.</summary>
        public static void EnsureFullNameIsValid(string firstName, string lastName)
        {
            if (!string.IsNullOrWhiteSpace(firstName) && firstName.Length > MaxNameLength)
                throw new DomainValidationException(
                    $"Имя не может быть длиннее {MaxNameLength} символов.",
                    nameof(User.FirstName));

            if (!string.IsNullOrWhiteSpace(lastName) && lastName.Length > MaxNameLength)
                throw new DomainValidationException(
                    $"Фамилия не может быть длиннее {MaxNameLength} символов.",
                    nameof(User.LastName));
        }
    }
}