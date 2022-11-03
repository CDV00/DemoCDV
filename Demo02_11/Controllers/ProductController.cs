using Demo02_11.Domain.Services;
using Demo02_11.Infrastructure.ViewModel.Product;
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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public  ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("Get-All")]
        public ActionResult<Reponses<ProductReponse>> GetAll()
        {
            var result = _productService.GetAll();
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("Get-By_Id/{id}")]
        public ActionResult<Reponse<ProductReponse>> GetById(Guid id)
        {
            var result =_productService.GetById(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("Add")]
        public async Task<ActionResult<BaseReponse>> Add(ProductResquest productResquest)
        {
            var result =await _productService.Add(productResquest);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<ActionResult<BaseReponse>> Update(ProductResquest productResquest)
        {
            var result = await _productService.Update(productResquest);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpDelete("Update")]
        public async Task<ActionResult<BaseReponse>> Detete(Guid id)
        {
            var result =await _productService.Delete(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

    }
}
