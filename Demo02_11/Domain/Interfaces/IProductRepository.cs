using Demo02_11.Domain.Models;
using System;

namespace Demo02_11.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        bool CheckExistByCategoryId(Guid id);
    }
}
