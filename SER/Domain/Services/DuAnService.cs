using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SER.Domain.Interfaces;
using SER.Domain.Models;
using SER.Infrastructure.Data;
using SER.Infrastructure.Repositories;
using SER.Infrastructure.ViewModel.DuAn;
using SER.Infrastructure.ViewModel.KhoKhan;
using SER.Infrastructure.ViewModel.Reponse;
using SER.Infrastructure.ViewModel.Resquest;
using System.Net;

namespace SER.Domain.Services
{
    public interface IDuAnService : IBaseService<Duan, DuAnReponse, DuAnResquest>
    {
    }

    public class DuAnService:BaseService<Duan,DuAnReponse,DuAnResquest>, IDuAnService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        public DuAnService(IUnitOfWork unitOfWork, IRepository<Duan> repository, IMapper mapper, ILogger<BaseService<Duan, DuAnReponse, DuAnResquest>> logger) :base(unitOfWork, repository, mapper, logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        //public override async Task<Reponses<DuAnReponse>> GetAllPaging(Parameter parameter)
        public override async Task<Reponses<DuAnReponse>> GetAllPaging(Parameter parameter)
        {
            try
            {
                var entities = _unitOfWork._duAnRepository.GetAll();
                var duAn = await entities.OrderBy(da=>da.Id).Skip((parameter.PageIndex - 1) * parameter.PageSize)
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
                _logger.LogError(ex, $"{nameof(GetAll)} function error on {nameof(DuAnService) + ex.Message}",typeof(DuAnService));
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
        }
    }
}


