namespace Repository.Interface
{
    public interface IUserRepository
    {
        public void GetByEmailAsync(string Email, CancellationToken cancellationToken = default);
        public void GetWithProfileAsync(Guid Id, CancellationToken cancellationToken = default);
        public void ExistsByEmailAsync(string Email, CancellationToken cancellationToken = default);
        public void GetByIdWithRefreshTokenAsync(Guid Id, CancellationToken cancellationToken = default);
        
    }
}