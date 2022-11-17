using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;
using SER.Infrastructure.ViewModel.DuAn;
using SER.Infrastructure.ViewModel.KhoKhan;
using SER.Infrastructure.ViewModel.Reponse;
using SER.Infrastructure.ViewModel.Resquest;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoKhanController : CRUDController<Khokhan, KhoKhanReponse, KhoKhanResquest>
    {
        private readonly IKhoKhanService _khoKhanService;

        public KhoKhanController( IKhoKhanService khoKhanService,IBaseService<Khokhan, KhoKhanReponse, KhoKhanResquest> service) : base(service)
        {
            _khoKhanService = khoKhanService;
        }
        /// <summary>
        /// lấy tất cả khó khăn không phân trang
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public override async Task<ActionResult<Reponses<KhoKhanReponse>>> GetAll()
        {
            var result = await _khoKhanService.GetAll();
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        /// <summary>
        /// lấy tất cả khó khăn có phân trang
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        [HttpPost("GetAllPaging")]
        public override async Task<ActionResult<Reponses<KhoKhanReponse>>> GetAllPaging(Parameter parameter)
        {
            var result = await _khoKhanService.GetAllPaging(parameter);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        /// <summary>
        /// Get khó khăn theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public override async Task<ActionResult<Reponse<KhoKhanReponse>>> GetById(int id)
        {
            var result = await _khoKhanService.GetById(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        /// <summary>
        /// lấy tất cả các khó khan có cùng dự án theo dự án Id có phân trang
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("GetByDuAnIdPaging")]
        public async Task<ActionResult<Reponse<KhoKhanReponse>>> GetByDuAnIdPaging(Parameter parameter,int id)
        {
            var result = await _khoKhanService.GetByDuAnIdPaging(parameter,id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        /// <summary>
        /// lấy tất cả các khó khan có cùng dự án theo dự án Id
        /// </summary>
        /// <param name="DuAnId"></param>
        /// <returns></returns>
        [HttpPost("GetByDuAnId")]
        public async Task<ActionResult<Reponse<KhoKhanReponse>>> GetByDuAnId(int DuAnId)
        {
            var result = await _khoKhanService.GetByDuAnId(DuAnId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }


}
