using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SER.Domain.Interfaces;
using SER.Domain.Models;
using SER.Infrastructure.ViewModel.DuAn;
using SER.Infrastructure.ViewModel.KhoKhan;
using SER.Infrastructure.ViewModel.Reponse;
using SER.Infrastructure.ViewModel.Resquest;

namespace SER.Domain.Services
{
    public interface IKhoKhanService : IBaseService<Khokhan, KhoKhanReponse, KhoKhanResquest>
    {
        Task<Reponses<KhoKhanReponse>> GetByDuAnId(int duanId);
        Task<Reponses<KhoKhanReponse>> GetByDuAnIdPaging(Parameter parameter, int duanId);
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
        /// <summary>
        /// lấy tất cả các khó khăn
        /// </summary>
        /// <returns></returns>
        public override async Task<Reponses<KhoKhanReponse>> GetAll()
        {
            try
            {
                var ResultModifier = _unitOfWork._khoKhanRepository.GetAlls();
                //result
                return new Reponses<KhoKhanReponse>(
                                                      true,
                                                      "Thành công",
                                                       _mapper.Map<List<KhoKhanReponse>>(await ResultModifier.ToListAsync())
                                                   );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(GetAllPaging)} function error on {nameof(KhoKhanService) + ex.Message}", typeof(KhoKhanService));
                return new Reponses<KhoKhanReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        /// <summary>
        /// get tất cả khó khăn, có phân trang
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public override async Task<Reponses<KhoKhanReponse>> GetAllPaging(Parameter parameter)
        {
            try
            {
                var ResultModifier = _unitOfWork._khoKhanRepository.GetAlls(orderBy: s => s.OrderBy(s => s.Id));
                //count row
                int totalRow = await ResultModifier.CountAsync();
                //paging
                ResultModifier.Skip((parameter.PageIndex - 1) * parameter.PageSize)
                              .Take(parameter.PageSize);
                //result
                return new Reponses<KhoKhanReponse>(
                                                      true,
                                                      "Thành công",
                                                      totalRow,
                                                       _mapper.Map<List<KhoKhanReponse>>(await ResultModifier.ToListAsync())
                                                   );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(GetAllPaging)} function error on {nameof(KhoKhanService) + ex.Message}", typeof(KhoKhanService));
                return new Reponses<KhoKhanReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        /// <summary>
        /// Get all kho khan thuoc 1 du an, co paging
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="duanId"></param>
        /// <returns></returns>
        public async Task<Reponses<KhoKhanReponse>> GetByDuAnIdPaging(Parameter parameter, int duanId)
        {
            try
            {
                var ResultModifier = _unitOfWork._khoKhanRepository.GetAlls(filter: s=>s.DuAnId == duanId,orderBy: s => s.OrderBy(s => s.Id));
                //count row
                int totalRow = await ResultModifier.CountAsync();
                //paging
                ResultModifier.Skip((parameter.PageIndex - 1) * parameter.PageSize)
                              .Take(parameter.PageSize);
                //result
                return new Reponses<KhoKhanReponse>(
                                                      true,
                                                      "Thành công",
                                                      totalRow,
                                                       _mapper.Map<List<KhoKhanReponse>>(await ResultModifier.ToListAsync())
                                                   );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(GetAllPaging)} function error on {nameof(KhoKhanService) + ex.Message}", typeof(KhoKhanService));
                return new Reponses<KhoKhanReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        /// <summary>
        /// Get all kho khan thuoc 1 du an
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="duanId"></param>
        /// <returns></returns>
        public async Task<Reponses<KhoKhanReponse>> GetByDuAnId(int duanId)
        {
            try
            {
                var ResultModifier = _unitOfWork._khoKhanRepository.GetAlls(filter: s => s.DuAnId == duanId, orderBy: s => s.OrderBy(s => s.Id));
                //result
                return new Reponses<KhoKhanReponse>(
                                                      true,
                                                      "Thành công",
                                                       _mapper.Map<List<KhoKhanReponse>>(await ResultModifier.ToListAsync())
                                                   );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(GetAllPaging)} function error on {nameof(KhoKhanService) + ex.Message}", typeof(KhoKhanService));
                return new Reponses<KhoKhanReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        /// <summary>
        /// get kho khan theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override async Task<Reponse<KhoKhanReponse>> GetById(int id)
        {
            try
            {
                var khoKhan = await _unitOfWork._khoKhanRepository.KhoKhanById(id).FirstOrDefaultAsync();
                if(khoKhan is null)
                {
                    return new Reponse<KhoKhanReponse>(false, "Id khong ton tai!");
                }
                return new Reponse<KhoKhanReponse>(
                                                    true,
                                                    "Thành công",
                                                     _mapper.Map<KhoKhanReponse>(khoKhan)
                                                  );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(GetById)} function error on {nameof(KhoKhanService) + ex.Message}", typeof(KhoKhanService));
                return new Reponse<KhoKhanReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
    }
}
