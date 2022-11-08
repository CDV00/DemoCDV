using AutoMapper;
using DemoGeneric.Domain.Interfaces;
using DemoGeneric.Domain.Models;
using DemoGeneric.Infrastructure.ViewModel.Category;
using DemoGeneric.Infrastructure.ViewModel.Reponse;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGeneric.Domain.Services
{
    public interface ICategoryService:IBaseService<Category, CategoryReponse, CategoryResquest>
    {
        
    }
    public class CategoryService: BaseService<Category, CategoryReponse, CategoryResquest> ,ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public CategoryService(IUnitOfWork unitOfWork , 
                                IMapper mapper, 
                                IRepository<Category> repository, 
                                ILogger<CategoryService> logger) 
                                :base(unitOfWork, repository, mapper, logger) 
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        
        
        
        /*public async Task<BaseReponse> Delete(Guid id)
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
        }*/

    }
}
