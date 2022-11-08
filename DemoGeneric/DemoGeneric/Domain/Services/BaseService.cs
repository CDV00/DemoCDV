using AutoMapper;
using DemoGeneric.Domain.Interfaces;
using DemoGeneric.Domain.Models;
using DemoGeneric.Infrastructure.Data;
using DemoGeneric.Infrastructure.ViewModel.Category;
using DemoGeneric.Infrastructure.ViewModel.Reponse;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGeneric.Domain.Services
{
    public interface IBaseService<TEntity, TReponse, TResquest> where TEntity : class
    {
        Task<BaseReponse> Add(TResquest resquest);
        Reponses<TReponse> GetAll();
        Task<Reponse<TReponse>> GetById(Guid id);
        Task<BaseReponse> Remove(Guid id);
        Task<BaseReponse> Update(TResquest resquest);
    }
    public class BaseService<TEntity, TReponse, TResquest> : IBaseService<TEntity, TReponse, TResquest> where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        public BaseService(IUnitOfWork unitOfWork, IRepository<TEntity> repository, IMapper mapper, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
        public BaseService(IUnitOfWork unitOfWork, IRepository<TEntity> repository, IMapper mapper, ILogger<BaseService<TEntity, TReponse, TResquest>> logger)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
        public virtual async Task<BaseReponse> Add(TResquest resquest)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(resquest);
                await _repository.CreateAsync(entity);
                await _unitOfWork.CommitAsync();

                return new BaseReponse(true, "Thêm thành công");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(Add)} function error on {nameof(BaseService<TEntity, TReponse,TResquest>)+ex.Message}", typeof(BaseService<,,>));
                return new BaseReponse(true, "Thêm thất bại "+ ex.Message);
            }
        }
        public virtual Reponses<TReponse> GetAll()
        {
            try
            {
                var categorys = _repository.GetAll().ToList();

                var Result = new Reponses<TReponse>(
                                                        true,
                                                        "Thành công",
                                                        _mapper.Map<List<TReponse>>(categorys)
                                                   );

                return Result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(GetAll)} function error on {nameof(BaseService<TEntity, TReponse, TResquest>) + ex.Message}", typeof(BaseService<,,>));
                return new Reponses<TReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }

        public virtual async Task<Reponse<TReponse>> GetById(Guid id)
        {
            try
            {
                //var product = _unitOfWork._ProductRepository.f;

                var entity = await _repository.GetById(id);
                //var productReponse = _mapper.Map<List<ProductReponse>>(products);

                var Result = new Reponse<TReponse>(
                    true,
                    "Thành công",
                    _mapper.Map<TReponse>(entity)
                    );

                return Result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(GetById)} function error on {nameof(BaseService<TEntity, TReponse, TResquest>) + ex.Message}", typeof(BaseService<,,>));
                return new Reponse<TReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        public virtual async Task<BaseReponse> Update(TResquest resquest)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(resquest);
                var update = _repository.Update(entity);
                await _unitOfWork.CommitAsync();

                return new BaseReponse(
                    true,
                    "Thành công"
                    );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(Update)} function error on {nameof(BaseService<TEntity, TReponse, TResquest>) + ex.Message}", typeof(BaseService<,,>));
                return new BaseReponse(false, "đã có lỗi: " + ex.Message);
            }
        }



        public virtual async Task<BaseReponse> Remove(Guid id)
        {
            try
            {
                var entity = await _repository.GetById(id);
                var Result = _repository.Delete(entity);
                if (!Result)
                {
                    return new BaseReponse(false, "đã có lỗi khi xóa ");
                }

                await _unitOfWork.CommitAsync();
                return new BaseReponse(true, "Thành công");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(Remove)} function error on {nameof(BaseService<TEntity, TReponse, TResquest>) + ex.Message}", typeof(BaseService<,,>));
                return new BaseReponse(false, "đã có lỗi: " + ex.Message);
            }
        }
    }
}
