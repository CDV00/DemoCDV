using AutoMapper;
using DemoGeneric.Domain.Interfaces;
using DemoGeneric.Domain.Models;
using DemoGeneric.Infrastructure.ViewModel.Category;
using DemoGeneric.Infrastructure.ViewModel.Detail;
using DemoGeneric.Infrastructure.ViewModel.Reponse;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGeneric.Domain.Services
{
    public interface IDetailService:IBaseService<Detail, DetailReponse, DetailResquest>
    {

    }
    public class DetailService: BaseService<Detail,DetailReponse,DetailResquest>, IDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        public DetailService(IUnitOfWork unitOfWork,
                                IMapper mapper,
                                IRepository<Detail> repository,
                                ILogger<DetailService> logger)
                                : base(unitOfWork, repository, mapper, logger) {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }


        /*public override async Task<BaseReponse> Update(DetailResquest detailResquest)
        {
            try
            {
                Guid detailId = _unitOfWork._DetailRepository.FindByProductId(detailResquest.ProductId);
                if (detailId.Equals(Guid.Empty))
                {
                    return new BaseReponse(false, "Khong tim thay san pham");
                }
                detailResquest.Id = detailId;

                var detail = _mapper.Map<Detail>(detailResquest);
                var result = _unitOfWork._DetailRepository.Update(detail);
                if (!result)
                    return new BaseReponse(false, "Thêm thất bại");
                await _unitOfWork.CommitAsync();
                return new BaseReponse(true, "Thêm thành công");
            }
            catch (Exception ex)
            {

                return new BaseReponse(false, "Thêm thất bại" + ex.Message);
            }
        }*/
        /*public override async Task<BaseReponse> Remove(Guid id)
        {
            try
            {
                var detail = await _unitOfWork._DetailRepository.GetById(id);
                var Result = _unitOfWork._DetailRepository.Delete(detail);
                if (!Result)
                {
                    return new BaseReponse(false, "đã có lỗi khi xóa ");
                }

                await _unitOfWork.CommitAsync();
                return new BaseReponse(true, "Thành công");
            }
            catch (Exception ex)
            {

                return new BaseReponse(false, "đã có lỗi: " + ex.Message);
            }
        }*/

        /*
        public Reponses<DetailReponse> GetAll()
        {
            try
            {

                var details = _unitOfWork._DetailRepository.GetAll().ToList();
                //var productReponse = _mapper.Map<List<ProductReponse>>(products);

                var Result = new Reponses<DetailReponse>(
                                                            true,
                                                            "Thành công",
                                                            _mapper.Map<List<DetailReponse>>(details)
                                                         );

                return Result;
            }
            catch (Exception ex)
            {

                return new Reponses<DetailReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        public async Task<Reponse<DetailReponse>> GetById(Guid id)
        {
            try
            {

                var detail = await _unitOfWork._DetailRepository.GetById(id);

                var Result = new Reponse<DetailReponse>(
                    true,
                    "Thành công",
                    _mapper.Map<DetailReponse>(detail)
                    );

                return Result;
            }
            catch (Exception ex)
            {

                return new Reponse<DetailReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        public async Task<BaseReponse> Update(DetailResquest detailResquest)
        {
            try
            {
                var detail = _mapper.Map<Detail>(detailResquest);
                var update = _unitOfWork._DetailRepository.Update(detail);
                if(!update)
                    return new BaseReponse(false, "đã có lỗi khi thay đổi ");

                await _unitOfWork.CommitAsync();
                return new BaseReponse(
                    true,
                    "Thành công"
                    );
            }
            catch (Exception ex)
            {

                return new BaseReponse(false, "đã có lỗi: " + ex.Message);
            }
        }
        */
    }
}
