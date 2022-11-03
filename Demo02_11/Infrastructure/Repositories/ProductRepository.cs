using Demo02_11.Domain.Interfaces;
using Demo02_11.Domain.Models;
using Demo02_11.Infrastructure.Data;
using System;
using System.Linq;

namespace Demo02_11.Infrastructure.Repositories
{
    public class ProductRepository: BaseRepository<Product>, IProductRepository
    {
        private readonly MyContext _context;
        public ProductRepository(MyContext context) : base(context)
        {
            _context = context;
        }
        public bool CheckExistByCategoryId(Guid id)
        {
            if (_context.Products.Where(m => m.CategoryId == id).Count() < 0)
                return false;
            return true;
        }
    }
}
