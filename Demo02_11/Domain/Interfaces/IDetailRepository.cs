using Demo02_11.Domain.Models;
using System;

namespace Demo02_11.Domain.Interfaces
{
    public interface IDetailRepository : IRepository<Detail>
    {
        Guid FindByProductId(Guid id);
    }
}
