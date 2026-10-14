using Entities;

namespace Repository.Interface
{
    public interface IRefreshTokenRepository
    {
        public void GetByTokenAsync(string Token);
        public void GetActiveByUserIdAsync(Guid Id);
        public void RevokeAllForUserAsync(Guid Id);
        public void AddAsync(RefreshToken Token);
    }
}