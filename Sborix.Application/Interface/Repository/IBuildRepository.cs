using Entities.Catalog;


namespace Repository.Interface
{
    public interface IBuildRepository
    {
        public void GetAll();
        public void GetByIdAsync(Guid id);
        public void GetByIdWithDetailsAsync(Guid id);
        public void SearchAsync(BuildFilter Filter);
        public void GetByOwnerIdAsync(Guid OwnerId);
        public void AddAsync(Build build);
        public void Update(Build build);
        public void Delete(Build build);
    }
}