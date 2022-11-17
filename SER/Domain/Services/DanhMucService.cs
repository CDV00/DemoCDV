using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SER.Domain.Interfaces;
using SER.Infrastructure.ViewModel.Reponse;
using SER.Infrastructure.ViewModel.Resquest;

namespace SER.Domain.Services
{
    public interface IDanhMucService<T> where T : class
    {
        Task<BaseReponse> Add(T resquest);
        Task<Reponses<T>> GetAll();
        Task<Reponses<T>> GetAllPaging(Parameter parameter);
        Task<Reponse<T>> GetById(int id);
        Task<BaseReponse> Remove(int id);
        Task<BaseReponse> Update(T resquest);
    }
    public class DanhMucService<T>:IDanhMucService<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<T> _repository;
        private readonly ILogger<DanhMucService<T>> _logger;

        public DanhMucService(IUnitOfWork unitOfWork, IRepository<T> repository, ILogger<DanhMucService<T>> logger)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _logger = logger;
        }
        public virtual async Task<BaseReponse> Add(T entity)
        {
            try
            {
                await _repository.CreateAsync(entity);
                await _unitOfWork.CommitAsync();

                return new BaseReponse(true, "Thêm thành công");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(Add)} function error on {nameof(DanhMucService<T>)+ex.Message}", typeof(DanhMucService<T>));
                return new BaseReponse(true, "Thêm thất bại " + ex.Message);
            }
        }
        public virtual async Task<Reponses<T>> GetAll()
        {
            try
            {
                var entities = await _repository.GetAll().ToListAsync();

                return new Reponses<T>(
                                                true,
                                                "Thành công",
                                                entities
                                             );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(Add)} function error on {nameof(DanhMucService<T>)+ex.Message}", typeof(DanhMucService<T>));
                return new Reponses<T>(false, "đã có lỗi: " + ex.Message);
            }
        }

        public virtual async Task<Reponses<T>> GetAllPaging(Parameter parameter)
        {
            try
            {
                var entities = await _repository.GetAll()
                                                 .Skip((parameter.PageIndex - 1) * parameter.PageSize)
                                                 .Take(parameter.PageSize)
                                                 .ToListAsync();
                int totalRow = await _repository.GetAll().CountAsync();

                //decimal totalpage = (decimal)(Convert.ToDecimal(count) / parameter.PageSize);


                //int TotalPage =(int)Math.Ceiling((decimal)(Convert.ToDecimal(count) / parameter.PageSize));

                return new Reponses<T>(
                                                true,
                                                "Thành công",
                                                totalRow,
                                                entities
                                             );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(Add)} function error on {nameof(DanhMucService<T>) + ex.Message}", typeof(DanhMucService<T>));
                return new Reponses<T>(false, "đã có lỗi: " + ex.Message);
            }
        }

        public virtual async Task<Reponse<T>> GetById(int id)
        {
            try
            {
                //var product = _unitOfWork._ProductRepository.f;

                var entity = await _repository.GetById(id);
                //var productReponse = _mapper.Map<List<ProductReponse>>(products);
                if(entity == null)
                {
                    return new Reponse<T>(
                                                false,
                                                "Danh muc khong ton tai!"
                                            );
                }
                return new Reponse<T>(
                                                true,
                                                "Thành công",
                                                entity
                                            );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(Add)} function error on {nameof(DanhMucService<T>) + ex.Message}", typeof(DanhMucService<T>));
                return new Reponse<T>(false, "đã có lỗi: " + ex.Message);
            }
        }
        public virtual async Task<BaseReponse> Update(T entity)
        {
            try
            {
                var update = _repository.Update(entity);
                await _unitOfWork.CommitAsync();

                return new BaseReponse(
                    true,
                    "Thành công"
                    );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(Add)} function error on {nameof(DanhMucService<T>) + ex.Message}", typeof(DanhMucService<T>));
                return new BaseReponse(false, "đã có lỗi: " + ex.Message);
            }
        }



        public virtual async Task<BaseReponse> Remove(int id)
        {
            try
            {
                var entity = await _repository.GetById(id);
                if (entity == null)
                {
                    return new BaseReponse(false,"Danh muc khong ton tai!");
                }
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
                _logger.LogError(ex, $"{nameof(Add)} function error on {nameof(DanhMucService<T>) + ex.Message}", typeof(DanhMucService<T>));
                return new BaseReponse(false, "đã có lỗi: " + ex.Message);
            }
        }
    }
}
