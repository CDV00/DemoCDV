using DemoGeneric.Domain.Interfaces;
using DemoGeneric.Domain.Models;
using DemoGeneric.Infrastructure.Data;
using DemoGeneric.Infrastructure.ViewModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGeneric.Infrastructure.Repositories
{
    public class CategoryRepository: BaseRepository<Category>,ICategoryRepository
    {
        private readonly DemoContext _context;
        public CategoryRepository(DemoContext context):base(context)
        {
            _context = context;
        }

        public async Task<CategoryReponse> GetCategory()
        {
            try
            {
                var categoryss = _context.Categories.AsEnumerable();
                IQueryable productss = _context.Products;
                IQueryable detailss= _context.Details;

                /*var Result = (from ca in categoryss
                              join po in productss ca.Id equals po.)*/

                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
