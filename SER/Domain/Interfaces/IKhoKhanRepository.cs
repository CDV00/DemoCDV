using SER.Domain.Models;
using SER.Infrastructure.ViewModel.KhoKhan;
using System.Linq.Expressions;

namespace SER.Domain.Interfaces
{
    public interface IKhoKhanRepository : IRepository<Khokhan>
    {
        IQueryable<Khokhan> GetAlls(Expression<Func<Khokhan,bool>> filter = null, Func<IQueryable<Khokhan>,IOrderedQueryable<Khokhan>> orderBy = null);
        IQueryable<Khokhan> KhoKhanById(int id);
    }
}
