namespace Sborix.Application.DTO.Account
{
    public class UserAddressDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Label { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string House { get; set; } = null!;
        public string? Apartment { get; set; }
        public string PostalCode { get; set; } = null!;
        public bool IsDefault { get; set; }
    }

    public class CreateUserAddressDto
    {
        public string Label { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string House { get; set; } = null!;
        public string? Apartment { get; set; }
        public string PostalCode { get; set; } = null!;
        public bool IsDefault { get; set; }
    }
}