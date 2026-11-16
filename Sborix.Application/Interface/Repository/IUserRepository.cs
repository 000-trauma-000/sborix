namespace Repository.Interface
{
    public interface IUserRepository
    {
        Task<global::Entities.User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<global::Entities.User?> GetWithProfileAsync(Guid id, CancellationToken cancellationToken = default);
        Task<bool> ExistsByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<global::Entities.User?> GetByIdWithRefreshTokenAsync(Guid id, CancellationToken cancellationToken = default);
        Task AddAsync(global::Entities.User user, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
