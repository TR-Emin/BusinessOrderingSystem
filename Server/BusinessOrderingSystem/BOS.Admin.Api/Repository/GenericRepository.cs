using BOS.Admin.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BOS.Admin.Api.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<int> AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetListAsync();
        Task<int> SaveChangesAsync();

        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        T GetById(int id);
        List<T> GetList();
        int SaveChanges();
    }


    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BOSContext _bOSContext;
        public GenericRepository(BOSContext bOSContext)
        {
            _bOSContext = bOSContext;
        }

        public int Add(T entity)
        {
            _bOSContext.Set<T>().Add(entity);
            return _bOSContext.SaveChanges();
        }
        public async Task<int> AddAsync(T entity)
        {
            await _bOSContext.Set<T>().AddAsync(entity);
            return await _bOSContext.SaveChangesAsync();
        }

        public int Update(T entity)
        {
            _bOSContext.Set<T>().Update(entity);
            return _bOSContext.SaveChanges();
        }

        public int Delete(T entity)
        {
            //T existing = _bOSContext.Set<T>().Find(id);
            _bOSContext.Set<T>().Remove(entity);
            return _bOSContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _bOSContext.Set<T>().Find(id);
        }
        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _bOSContext.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _bOSContext.Entry(entity).State = EntityState.Detached; // FindAsync() ile beraber AsNoTracking() kullanamadığımdan dolayı obje izleme hatası çözümü bu şekilde çözülmüştür.
            }
            return entity;
        }

        public List<T> GetList()
        {
            return _bOSContext.Set<T>().ToList();
        }
        public async Task<List<T>> GetListAsync()
        {
            return await _bOSContext.Set<T>().ToListAsync();
        }

        public int SaveChanges()
        {
            return _bOSContext.SaveChanges();
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _bOSContext.SaveChangesAsync();
        }


    }

}
