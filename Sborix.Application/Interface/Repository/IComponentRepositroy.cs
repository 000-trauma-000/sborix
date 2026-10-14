using Entities.Catalog;

namespace Repository.Interface
{
    public interface IComponentRepositroy
    {
        public void GetByIdAsync(Guid Id);
        public void GetByTypeAsync(ComponentFilter filter);
        public void SearchAsync(ComponentFilter filter);
        public void AddAsync(Component component);
    }
}