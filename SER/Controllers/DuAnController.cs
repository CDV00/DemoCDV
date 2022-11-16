using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;
using SER.Infrastructure.ViewModel.DuAn;
using SER.Infrastructure.ViewModel.Reponse;
using SER.Infrastructure.ViewModel.Resquest;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuAnController : CRUDController<Duan, DuAnReponse, DuAnResquest>
    {
        private readonly IDuAnService _duAnService;

        public DuAnController(IDuAnService duAnService,IBaseService<Duan, DuAnReponse, DuAnResquest> service) : base(service)
        {
            _duAnService = duAnService;
        }
        [HttpPost("GetAllPaging")]
        public override async Task<ActionResult<Reponses<DuAnReponse>>> GetAllPaging(Parameter parameter)
        {
            var result = await _duAnService.GetAllPaging(parameter);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("GetById/{id}")]
        public override async Task<ActionResult<Reponse<DuAnReponse>>> GetById(int id)
        {
            var result = await _duAnService.GetById(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
