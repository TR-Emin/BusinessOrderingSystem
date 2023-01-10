using BOS.Admin.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BOS.Admin.Api.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetListAsync();
        Task<int> SaveChangesAsync();

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
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

        public void Add(T entity)
        {
            _bOSContext.Set<T>().Add(entity);
        }
        public async Task AddAsync(T entity)
        {
            await _bOSContext.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _bOSContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            //T existing = _bOSContext.Set<T>().Find(id);
            _bOSContext.Set<T>().Remove(entity);
        }

        public T GetById(int id)
        {
            return _bOSContext.Set<T>().Find(id);
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _bOSContext.Set<T>().FindAsync(id);
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
