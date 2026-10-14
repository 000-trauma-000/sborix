using Entities.Catalog;

namespace Entities.Account
{
    /// <summary>Сборка, добавленная пользователем в избранное.</summary>
    public class FavouriteBuild : BaseEntity
    {
        public Guid UserId { get; set; }                    // кто добавил
        public User User { get; set; } = null!;

        public Guid BuildId { get; set; }                   // какая сборка
        public Build Build { get; set; } = null!;
    }
}