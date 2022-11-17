using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SER.Domain.Interfaces;
using SER.Domain.Models;
using SER.Infrastructure.Data;

namespace SER.Infrastructure.Repositories
{
    public class Repository<T>:IRepository<T> where T : class
    {
        protected DbSet<T> DbSet;
        private readonly VI_GPMBContext _context;
        public Repository(VI_GPMBContext context)
        {
            DbSet = context.Set<T>();
            _context = context;
        }

        public DbSet<T> Entity()
        {
            return DbSet;
        }

        public IQueryable<T> GetAll() => DbSet.AsNoTracking();

        public virtual async Task<T> GetById(int id)
        {
            try
            {
                //var data = await DbSet.FindAsync(id);
                return await DbSet.FindAsync(id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            
        }
        public virtual async Task CreateAsync(T _object) => await DbSet.AddAsync(_object);
        public virtual bool Update(T _object)
        {
            DbSet.Attach(_object);
            _context.Entry(_object).State = EntityState.Modified;
            return true;

        }
        public virtual bool Delete(T _object)
        {
            /* var data = DbSet.FindAsync(_object);
             if(data == null)
             {
                 return false;
             }*/

            DbSet.Remove(_object);

            return true;

        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
