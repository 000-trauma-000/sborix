using Entities;

namespace Repository.Interface
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken?> GetByTokenAsync(string token);
        Task<RefreshToken?> GetActiveByUserIdAsync(Guid id);
        Task RevokeAllForUserAsync(Guid id);
        Task AddAsync(RefreshToken token);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}