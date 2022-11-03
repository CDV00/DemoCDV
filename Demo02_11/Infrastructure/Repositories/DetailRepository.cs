using Demo02_11.Domain.Interfaces;
using Demo02_11.Domain.Models;
using Demo02_11.Infrastructure.Data;
using System;
using System.Linq;

namespace Demo02_11.Infrastructure.Repositories
{
    public class DetailRepository: BaseRepository<Detail>, IDetailRepository
    {
        private readonly MyContext _context;
        public DetailRepository(MyContext context) : base(context)
        {
            _context = context;
        }

        public Guid FindByProductId(Guid id)
        {
            Guid DetailId = _context.Details.Where(d => d.ProductId == id).Select(m => m.Id).FirstOrDefault();
            if (DetailId == null)
                return Guid.Empty;
            return DetailId;
        }
    }
}
