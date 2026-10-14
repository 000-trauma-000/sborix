namespace Sborix.Application.DTO.Account
{
    public class FavouriteBuildDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid BuildId { get; set; }
    }

    public class CreateFavouriteBuildDto
    {
        public Guid BuildId { get; set; }
    }
}