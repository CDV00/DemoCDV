using DemoGeneric.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGeneric.Domain.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
