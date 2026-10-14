namespace Sborix.Application.DTO.Profile
{
    public class ProfileDto
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? AvatarUrl { get; set; }
        public string? BIO { get; set; }
        public string Residence { get; set; } = null!;
    }

    public class UpdateProfileDto
    {
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? AvatarUrl { get; set; }
        public string? BIO { get; set; }
        public string Residence { get; set; } = null!;
    }
}