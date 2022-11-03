using Demo02_11.Domain.Interfaces;
using Demo02_11.Domain.Models;
using Demo02_11.Infrastructure.Data;

namespace Demo02_11.Infrastructure.Repositories
{
    public class DetailRepository: BaseRepository<Detail>, IProductRepository
    {
        private MyContext _context;
        public DetailRepository(MyContext context) : base(context)
        {
            _context = context;
        }
    }
}
