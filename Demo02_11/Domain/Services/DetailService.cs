using AutoMapper;
using Demo02_11.Domain.Interfaces;
using Demo02_11.Domain.Models;
using Demo02_11.Infrastructure.ViewModel.Detail;
using Demo02_11.Infrastructure.ViewModel.Reponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo02_11.Domain.Services
{
    public interface IDetailService
    {
        Task<BaseReponse> Add(DetailResquest detailResquest);
        Task<BaseReponse> Delete(Guid id);
        Reponses<DetailReponse> GetAll();
        Task<Reponse<DetailReponse>> GetById(Guid id);
        Task<BaseReponse> Update(DetailResquest detailResquest);
    }
    public class DetailService: IDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DetailService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseReponse> Add(DetailResquest detailResquest)
        {
            try
            {
                Guid detailId = _unitOfWork._DetailRepository.FindByProductId(detailResquest.ProductId);
                if (detailId.Equals(Guid.Empty))
                {
                    return new BaseReponse(false, "Khong tim thay san pham");
                }
                //var detail = _unitOfWork._DetailRepository
                //var detail = await _unitOfWork._DetailRepository.GetById(detailResquest);
                detailResquest.Id = detailId;

               var detail = _mapper.Map<Detail>(detailResquest);
                var result = _unitOfWork._DetailRepository.Update(detail);
                if(!result)
                    return new BaseReponse(false, "Thêm thất bại");
                await _unitOfWork.CommitAsync();
                return new BaseReponse(true, "Thêm thành công");
            }
            catch (Exception ex)
            {

                return new BaseReponse(false, "Thêm thất bại"+ex.Message);
            }
        }
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
        public async Task<BaseReponse> Delete(Guid id)
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
        }
    }
}
