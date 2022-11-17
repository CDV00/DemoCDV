﻿using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DmBuocTinhtrangduanController : DanhMucController<DmBuocTinhtrangduan>
    {
        public DmBuocTinhtrangduanController(IDanhMucService<DmBuocTinhtrangduan> service) : base(service)
        {
        }
    }

}