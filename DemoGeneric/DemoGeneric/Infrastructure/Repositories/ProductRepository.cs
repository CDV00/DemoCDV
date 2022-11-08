using DemoGeneric.Domain.Interfaces;
using DemoGeneric.Domain.Models;
using DemoGeneric.Infrastructure.Data;
using System;
using System.Linq;

namespace DemoGeneric.Infrastructure.Repositories
{
    public class ProductRepository: BaseRepository<Product>, IProductRepository
    {
        private readonly DemoContext _context;
        public ProductRepository(DemoContext context) : base(context)
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
