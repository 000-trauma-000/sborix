using Entities.Deal;
namespace Repository.Interface
{
    public interface IBookingRepository
    {
        public void GetByIdAsync(Guid Id);
        public void GetByUserIdAsync(Guid userId);
        public void GetByBuildAsync(Guid buildId);
        public void AddAsync(Booking booking);
        public void Update(Booking booking);
        public void GetActiveByBuildIdAsync(Guid buildId);
        public void HasOverlapAsync(Guid buildId, DateTime start, DateTime end);


    }
}