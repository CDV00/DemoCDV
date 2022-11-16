using AutoMapper;
using SER.Domain.Interfaces;
using SER.Domain.Models;
using SER.Infrastructure.ViewModel.KhoKhan;

namespace SER.Domain.Services
{
    public interface IKhoKhanService : IBaseService<Khokhan, KhoKhanReponse, KhoKhanResquest>
    {
    }
    public class KhoKhanService : BaseService<Khokhan, KhoKhanReponse, KhoKhanResquest>, IKhoKhanService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        public KhoKhanService(IUnitOfWork unitOfWork, IRepository<Khokhan> repository, IMapper mapper, ILogger<BaseService<Khokhan, KhoKhanReponse, KhoKhanResquest>> logger) : base(unitOfWork, repository, mapper, logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        //public override async Task<Reponses<DuAnReponse>> GetAllPaging(Parameter parameter)
        /* public override async Task<Reponses<DuAnReponse>> GetAllPaging(Parameter parameter)
         {
             try
             {
                 var entities = _unitOfWork._duAnRepository.GetAll();
                 var duAn = await entities.OrderBy(da => da.Id).Skip((parameter.PageIndex - 1) * parameter.PageSize)
                                      .Take(parameter.PageSize)
                                      .ToListAsync();
                 var duAns = _mapper.Map<List<DuAnReponse>>(duAn);
                 int totalRow = await entities.CountAsync();
                 await _unitOfWork._duAnRepository.AddDM(duAns, null);

                 return new Reponses<DuAnReponse>(
                                                 true,
                                                 "Thành công",
                                                 totalRow,
                                                 duAns
                                              );
             }
             catch (Exception ex)
             {
                 _logger.LogError(ex, $"{nameof(GetAll)} function error on {nameof(DuAnService) + ex.Message}", typeof(DuAnService));
                 return new Reponses<DuAnReponse>(false, "đã có lỗi: " + ex.Message);
             }
         }
         public override async Task<Reponse<DuAnReponse>> GetById(int id)
         {
             try
             {
                 var duAn = _mapper.Map<DuAnReponse>(await _unitOfWork._duAnRepository.GetById(id));
                 await _unitOfWork._duAnRepository.AddDM(null, duAn);

                 return new Reponse<DuAnReponse>(
                                                 true,
                                                 "Thành công",
                                                 duAn
                                              );
             }
             catch (Exception ex)
             {
                 _logger.LogError(ex, $"{nameof(GetById)} function error on {nameof(DuAnService) + ex.Message}", typeof(DuAnService));
                 return new Reponse<DuAnReponse>(false, "đã có lỗi: " + ex.Message);
             }
         }*/
    }
}
