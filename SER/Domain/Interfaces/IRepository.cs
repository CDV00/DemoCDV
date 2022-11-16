namespace SER.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T _object);
        bool Delete(T _object);
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        bool Update(T _object);
    }
}
