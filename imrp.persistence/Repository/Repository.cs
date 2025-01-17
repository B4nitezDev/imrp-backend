
using imrp.domain.Entities;
using imrp.domain.Interfaces;
using imrp.persistence.Database;

namespace imrp.persistence.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IrmpDbContext _context;

        public Repository(IrmpDbContext context)
        {
            _context = context;
        }

        public T Add(T toSave)
        {
            var entity = _context.Add(toSave);
            _context.SaveChanges();
            return entity.Entity;
        }

        public void Delete(T entity)
        {
            var existing = _context.Set<T>().Find(entity.Id);
            if (existing is null)
            {
                throw new InvalidDataException("Entity not found");
            }
            _context.Remove(existing);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var existing = _context.Set<T>().Find(entity.Id);
            if (existing is null)
            {
                throw new InvalidDataException("Entity not found");
            }
            _context.Entry(existing).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IQueryable<T> IQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}