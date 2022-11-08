using DemoGeneric.Domain.Models;
using System;

namespace DemoGeneric.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        bool CheckExistByCategoryId(Guid id);
    }
}
