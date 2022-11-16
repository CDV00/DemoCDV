using SER.Domain.Models;
using SER.Infrastructure.ViewModel.DuAn;
using SER.Infrastructure.ViewModel.Resquest;

namespace SER.Domain.Interfaces
{
    public interface IDuAnRepository : IRepository<Duan>
    {
        Task AddDM(List<DuAnReponse>? listDuAn, DuAnReponse? duAn);
        IQueryable<DuAnReponse> GetAlls();
        //Task<List<DuAnReponse>> GetAllPaging(Parameter parameter);
    }
}
