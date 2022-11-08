using DemoGeneric.Domain.Models;
using DemoGeneric.Domain.Services;
using DemoGeneric.Infrastructure.ViewModel.Category;
using DemoGeneric.Infrastructure.ViewModel.Product;
using DemoGeneric.Infrastructure.ViewModel.Reponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGeneric.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<Product, ProductReponse, ProductResquest>
    {
        private readonly IProductService _productService;

        public  ProductController(IProductService productService, IBaseService<Product, ProductReponse, ProductResquest> service) :base(service)
        {
            _productService = productService;
        }
        

    }
}
