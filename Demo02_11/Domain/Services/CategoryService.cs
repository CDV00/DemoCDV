using AutoMapper;
using Demo02_11.Domain.Interfaces;
using Demo02_11.Domain.Models;
using Demo02_11.Infrastructure.ViewModel.Category;
using Demo02_11.Infrastructure.ViewModel.Reponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo02_11.Domain.Services
{
    public interface ICategoryService
    {
        Task<BaseReponse> Add(CategoryResquest categoryResquest);
        Task<BaseReponse> Delete(Guid id);
        Reponses<CategoryReponse> GetAll();
        Task<Reponse<CategoryReponse>> GetById(Guid id);
        Task<BaseReponse> Update(CategoryResquest categoryResquest);
    }
    public class CategoryService: ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseReponse> Add(CategoryResquest categoryResquest)
        {
            try
            {
                var category = _mapper.Map<Category>(categoryResquest);
                await _unitOfWork._CategoryRepository.CreateAsync(category);
                await _unitOfWork.CommitAsync();

                return new BaseReponse(true,"Thêm thành công");
            }
            catch (Exception)
            {

                return new BaseReponse(true, "Thêm thất bại");
            }
        }
        public Reponses<CategoryReponse> GetAll()
        {
            try
            {

                var categorys = _unitOfWork._CategoryRepository.GetAll().ToList();
                //var productReponse = _mapper.Map<List<ProductReponse>>(products);

                var Result = new Reponses<CategoryReponse>(
                                                            true,
                                                            "Thành công",
                                                            _mapper.Map<List<CategoryReponse>>(categorys)
                                                         );

                return Result;
            }
            catch (Exception ex)
            {

                return new Reponses<CategoryReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        public async Task<Reponse<CategoryReponse>> GetById(Guid id)
        {
            try
            {
                //var product = _unitOfWork._ProductRepository.f;

                var category = await _unitOfWork._CategoryRepository.GetById(id);
                //var productReponse = _mapper.Map<List<ProductReponse>>(products);

                var Result = new Reponse<CategoryReponse>(
                    true,
                    "Thành công",
                    _mapper.Map<CategoryReponse>(category)
                    );

                return Result;
            }
            catch (Exception ex)
            {

                return new Reponse<CategoryReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        public async Task<BaseReponse> Update(CategoryResquest categoryResquest)
        {
            try
            {
                var category = _mapper.Map<Category>(categoryResquest);
                var update = _unitOfWork._CategoryRepository.Update(category);
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
                if (!_unitOfWork._ProductRepository.CheckExistByCategoryId(id))
                {
                    return new BaseReponse(false, "không thể xóa danh mục vì vẫn còn sản phẩm tồn tại");
                }
                var category = await _unitOfWork._CategoryRepository.GetById(id);
                var Result = _unitOfWork._CategoryRepository.Delete(category);
                if (!Result)
                {
                    return new BaseReponse(false, "đã có lỗi khi xóa " + category.Name);
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
