using imrp.domain.Entities;

namespace imrp.domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
        IQueryable<T> IQueryable();
        void SaveChanges();
    }
}
