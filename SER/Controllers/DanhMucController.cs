﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SER.Domain.Services;
using SER.Infrastructure.ViewModel.Reponse;
using SER.Infrastructure.ViewModel.Resquest;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucController<T> : ControllerBase where T : class
    {
        public readonly IDanhMucService<T> _service;

        public DanhMucController(IDanhMucService<T> service)
        {
            _service = service;
        }
        [HttpGet("GetAll")]
        public virtual async Task<ActionResult<Reponses<T>>> GetAll()
        {
            var result = await _service.GetAll();
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("GetAllPaging")]
        public virtual async Task<ActionResult<Reponses<T>>> GetAllPaging(Parameter parameter)
        {
            var result = await _service.GetAllPaging(parameter);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("GetById/{id}")]
        public virtual async Task<ActionResult<Reponse<T>>> GetById(int id)
        {
            var result = await _service.GetById(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("Add")]
        public async Task<ActionResult<BaseReponse>> Add(T resquest)
        {
            var result = await _service.Add(resquest);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("Update")]
        public async Task<ActionResult<BaseReponse>> Update(T resquest)
        {
            var result = await _service.Update(resquest);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("Delete/{id}")]
        public async Task<ActionResult<BaseReponse>> Detete(int id)
        {
            var result = await _service.Remove(id);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}