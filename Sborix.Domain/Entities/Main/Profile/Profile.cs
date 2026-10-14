namespace Entities
{
    public class Profile : BaseEntity
    {
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? AvatarUrl { get; set; }
        public string? BIO { get; set; }
        public string Residence { get; set; } = null!;
    }
}
