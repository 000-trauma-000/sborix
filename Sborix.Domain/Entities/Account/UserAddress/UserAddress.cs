namespace Entities.Account
{
    /// <summary>Адрес пользователя (для доставки компонентов).</summary>
    public class UserAddress : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public string Label { get; set; } = null!;          // «Дом», «Работа»
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string House { get; set; } = null!;
        public string? Apartment { get; set; }
        public string PostalCode { get; set; } = null!;
        public bool IsDefault { get; set; }                 // адрес по умолчанию
    }
}