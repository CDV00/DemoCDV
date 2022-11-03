using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo02_11.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T _object);
        bool Delete(T _object);
        IQueryable<T> GetAll();
        Task<T> GetById(Guid id);
        bool Update(T _object);
    }
}
