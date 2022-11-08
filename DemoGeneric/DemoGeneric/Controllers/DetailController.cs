using DemoGeneric.Domain.Models;
using DemoGeneric.Domain.Services;
using DemoGeneric.Infrastructure.ViewModel.Detail;
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
    public class DetailController :BaseController<Detail, DetailReponse, DetailResquest>
    {
        private readonly IDetailService _detailService;

        public DetailController(IDetailService detailService, IBaseService<Detail, DetailReponse, DetailResquest> service):base(service)
        {
            _detailService = detailService;
        }
    }
}
