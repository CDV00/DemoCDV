using DemoGeneric.Domain.Models;
using System;

namespace DemoGeneric.Domain.Interfaces
{
    public interface IDetailRepository : IRepository<Detail>
    {
        Guid FindByProductId(Guid id);
    }
}
