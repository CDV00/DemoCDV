using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoGeneric.Domain.Interfaces;
using DemoGeneric.Infrastructure.ViewModel.Category;
using DemoGeneric.Infrastructure.ViewModel.Product;
using DemoGeneric.Infrastructure.ViewModel.Detail;
using AutoMapper;
using DemoGeneric.Domain.Models;
using DemoGeneric.Infrastructure.ViewModel.Reponse;
using Microsoft.Extensions.Logging;

namespace DemoGeneric.Domain.Services
{
    public interface IProductService:IBaseService<Product, ProductReponse, ProductResquest>
    {
        /*Task<BaseReponse> Add(ProductResquest productResquest);
        Task<BaseReponse> Delete(Guid id);
        Reponses<ProductReponse> GetAll();
        Reponse<ProductReponse> GetById(Guid id);
        Task<BaseReponse> Update(ProductResquest productResquest);*/
    }
    public class ProductService:BaseService<Product, ProductReponse, ProductResquest>, IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ProductService(IUnitOfWork unitOfWork,
                                IMapper mapper,
                                IRepository<Product> repository,
                                ILogger<ProductService> logger)
                                : base(unitOfWork, repository, mapper, logger) {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        /*public async Task<BaseReponse> Add(ProductResquest productResquest)
        {
            try
            {
                var product = _mapper.Map<Product>(productResquest);
                await _unitOfWork._ProductRepository.CreateAsync(product);

                await _unitOfWork.CommitAsync();
                return new BaseReponse(true,"Thêm sản phẩm thành công");
            }
            catch (Exception)
            {

                return new BaseReponse(false, "Thêm sản phẩm thất bại");
            }   
        }
        public Reponses<ProductReponse> GetAll()
        {
            try
            {
                
                var products = _unitOfWork._ProductRepository.GetAll().ToList();
                //var productReponse = _mapper.Map<List<ProductReponse>>(products);

                var Result = new Reponses<ProductReponse>(
                                                            true,
                                                            "Thành công",
                                                            _mapper.Map<List<ProductReponse>>(products)
                                                         );

                return Result;
            }
            catch (Exception ex)
            {

                return new Reponses<ProductReponse>(false, "đã có lỗi: "+ex.Message);
            }
        }
        public Reponse<ProductReponse> GetById(Guid id)
        {
            try
            {
                //var product = _unitOfWork._ProductRepository.f;

                var products = _unitOfWork._ProductRepository.GetById(id);
                //var productReponse = _mapper.Map<List<ProductReponse>>(products);

                var Result = new Reponse<ProductReponse>(
                    true,
                    "Thành công",
                    _mapper.Map<ProductReponse>(products)
                    );

                return Result;
            }
            catch (Exception ex)
            {

                return new Reponse<ProductReponse>(false, "đã có lỗi: " + ex.Message);
            }
        }
        public async Task<BaseReponse> Update(ProductResquest productResquest)
        {
            try
            {
                var product = _mapper.Map<Product>(productResquest);
                var products = _unitOfWork._ProductRepository.Update(product);

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
                var product =await _unitOfWork._ProductRepository.GetById(id);
                var Result = _unitOfWork._ProductRepository.Delete(product);
                if (!Result)
                {
                    return new BaseReponse(false, "đã có lỗi khi xóa "+product.Name);
                }

                await _unitOfWork.CommitAsync();
                return new BaseReponse( true,  "Thành công" );
            }
            catch (Exception ex)
            {

                return new BaseReponse(false, "đã có lỗi: " + ex.Message);
            }
        }*/
    }
}
