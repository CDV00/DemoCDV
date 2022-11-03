using Demo02_11.Domain.Interfaces;
using Demo02_11.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo02_11.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> DbSet;
        private readonly MyContext _context;
        public BaseRepository(MyContext context)
        {
            DbSet = context.Set<T>();
            _context = context;
        }

        public DbSet<T> Entity()
        {
            return DbSet;
        }

        public IQueryable<T> GetAll() => DbSet.AsNoTracking();

        public virtual async Task<T> GetById(T _object)
        {
            var data = await DbSet.FindAsync(_object);
            return data;
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


    }
}
