using DemoGeneric.Domain.Interfaces;
using DemoGeneric.Domain.Models;
using DemoGeneric.Infrastructure.Data;
using System;
using System.Linq;

namespace DemoGeneric.Infrastructure.Repositories
{
    public class DetailRepository: BaseRepository<Detail>, IDetailRepository
    {
        private readonly DemoContext _context;
        public DetailRepository(DemoContext context) : base(context)
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
