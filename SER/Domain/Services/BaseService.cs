using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SER.Domain.Interfaces;
using SER.Infrastructure.ViewModel.Reponse;
using SER.Infrastructure.ViewModel.Resquest;
using System.Net.NetworkInformation;

namespace SER.Domain.Services
{
    public interface IBaseService<TEntity, TReponse, TResquest> where TEntity : class
    {
        Task<BaseReponse> Add(TResquest resquest);
        Task<Reponses<TReponse>> GetAll();
        Task<Reponses<TReponse>> GetAllPaging(Parameter parameter);
        Task<Reponse<TReponse>> GetById(int id);
        Task<BaseReponse> Remove(int id);
        Task<BaseReponse> Update(TResquest resquest);
    }
    public class BaseService<TEntity, TReponse, TResquest>: IBaseService<TEntity, TReponse, TResquest> where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<BaseService<TEntity, TReponse, TResquest>> _logger;

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
                return new BaseReponse(true, "Thêm thất bại " + ex.Message);
            }
        }
        public virtual async Task<Reponses<TReponse>> GetAll()
        {
            try
            {
                var entities = await _repository.GetAll().ToListAsync();

                return new Reponses<TReponse>(
                                                true,
                                                "Thành công",
                                                _mapper.Map<List<TReponse>>(entities)
                                             );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(GetAll)} function error on {nameof(BaseService<TEntity, TReponse, TResquest>) + ex.Message}", typeof(BaseService<,,>));
                return new Reponses<TReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        public virtual async Task<Reponses<TReponse>> GetAllPaging(Parameter parameter)
        {
            try
            {
                var entities = await _repository.GetAll()
                                                 .Skip((parameter.PageIndex -1)*parameter.PageSize)
                                                 .Take(parameter.PageSize)
                                                 .ToListAsync();
                int totalRow = await _repository.GetAll().CountAsync();

                //decimal totalpage = (decimal)(Convert.ToDecimal(count) / parameter.PageSize);
                

                //int TotalPage =(int)Math.Ceiling((decimal)(Convert.ToDecimal(count) / parameter.PageSize));

                return new Reponses<TReponse>(
                                                true,
                                                "Thành công",
                                                totalRow,
                                                _mapper.Map<List<TReponse>>(entities)
                                             );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(GetAll)} function error on {nameof(BaseService<TEntity, TReponse, TResquest>) + ex.Message}", typeof(BaseService<,,>));
                return new Reponses<TReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }

        public virtual async Task<Reponse<TReponse>> GetById(int id)
        {
            try
            {
                //var product = _unitOfWork._ProductRepository.f;

                var entity = await _repository.GetById(id);
                //var productReponse = _mapper.Map<List<ProductReponse>>(products);

                return new Reponse<TReponse>(
                                                true,
                                                "Thành công",
                                                _mapper.Map<TReponse>(entity)
                                            );
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



        public virtual async Task<BaseReponse> Remove(int id)
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
