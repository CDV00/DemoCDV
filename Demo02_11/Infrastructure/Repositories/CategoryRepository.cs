using Demo02_11.Domain.Interfaces;
using Demo02_11.Domain.Models;
using Demo02_11.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo02_11.Infrastructure.Repositories
{
    public class CategoryRepository: BaseRepository<Category>,ICategoryRepository
    {
        private readonly MyContext _context;
        public CategoryRepository(MyContext context):base(context)
        {
            _context = context;
        }

    }
}
