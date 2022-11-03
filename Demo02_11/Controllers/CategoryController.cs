using Demo02_11.Domain.Services;
using Demo02_11.Infrastructure.ViewModel.Category;
using Demo02_11.Infrastructure.ViewModel.Reponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo02_11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("Get-All")]
        public ActionResult<Reponses<CategoryReponse>> GetAll()
        {
            var result = _categoryService.GetAll();
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
            
        [HttpGet("Get-By-Id/{id}")]
        public async Task<ActionResult<Reponse<CategoryReponse>>> GetById(Guid id)
        {
            var result = await _categoryService.GetById(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("Add")]
        public async Task<ActionResult<BaseReponse>> Add(CategoryResquest categoryResquest)
        {
            var result =await _categoryService.Add(categoryResquest);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<ActionResult<BaseReponse>> Update(CategoryResquest categoryResquest)
        {
            var result =await _categoryService.Update(categoryResquest);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpDelete("Update")]
        public async Task<ActionResult<BaseReponse>> Detete(Guid id)
        {
            var result =await _categoryService.Delete(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
