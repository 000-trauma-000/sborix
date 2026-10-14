namespace Entities.DomainExceptions
{
    /// <summary>Некорректные данные (пустое имя, отрицательная цена и т.п.).</summary>
    public class DomainValidationException : DomainException
    {
        public DomainValidationException(string message, string? propertyName = null)
            : base(message)
        {
            PropertyName = propertyName;
        }

        /// <summary>Имя свойства, к которому относится ошибка (для ответа API).</summary>
        public string? PropertyName { get; }
    }
}