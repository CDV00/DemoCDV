using DemoGeneric.Domain.Services;
using DemoGeneric.Infrastructure.ViewModel.Category;
using DemoGeneric.Infrastructure.ViewModel.Reponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace DemoGeneric.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TReponse, TResquest> : ControllerBase where TEntity : class
    {
        public readonly IBaseService<TEntity, TReponse, TResquest> _service;

        public BaseController(IBaseService<TEntity, TReponse, TResquest> service)
        {
            _service = service;
        }
        [HttpGet("GetAll")]
        public virtual ActionResult<Reponses<TReponse>> GetAll()
        {
            var result = _service.GetAll();
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("GetById/{id}")]
        public virtual async Task<ActionResult<Reponse<TReponse>>> GetById(Guid id)
        {
            var result = await _service.GetById(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("Add")]
        public async Task<ActionResult<BaseReponse>> Add(TResquest resquest)
        {
            var result = await _service.Add(resquest);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<ActionResult<BaseReponse>> Update(TResquest resquest)
        {
            var result = await _service.Update(resquest);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<ActionResult<BaseReponse>> Detete(Guid id)
        {
            var result = await _service.Remove(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
