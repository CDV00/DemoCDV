using Demo02_11.Domain.Services;
using Demo02_11.Infrastructure.ViewModel.Detail;
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
    public class DetailController : ControllerBase
    {
        private readonly IDetailService _detailService;

        public DetailController(IDetailService detailService)
        {
            _detailService = detailService;
        }
        [HttpGet("Get-All")]
        public ActionResult<Reponses<DetailReponse>> GetAll()
        {
            var result =_detailService.GetAll();
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("Get-By_Id/{id}")]
        public async Task<ActionResult<Reponse<DetailReponse>>> GetById(Guid id)
        {
            var result =await _detailService.GetById(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("Add")]
        public async Task<ActionResult<BaseReponse>> Add(DetailResquest detailResquest)
        {
            var result = await _detailService.Add(detailResquest);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPut("Update")]
        public async Task<ActionResult<BaseReponse>> Update(DetailResquest detailResquest)
        {
            var result = await _detailService.Update(detailResquest);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpDelete("Update")]
        public async Task<ActionResult<BaseReponse>> Detete(Guid id)
        {

            var result =await _detailService.Delete(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
