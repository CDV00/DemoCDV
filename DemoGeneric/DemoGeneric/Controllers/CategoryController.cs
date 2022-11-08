using DemoGeneric.Domain.Models;
using DemoGeneric.Domain.Services;
using DemoGeneric.Infrastructure.ViewModel.Category;
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
    public class CategoryController : BaseController<Category, CategoryReponse, CategoryResquest>
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService, IBaseService<Category, CategoryReponse, CategoryResquest> service) : base(service)
        {
            _categoryService = categoryService;
        }
    }
}
