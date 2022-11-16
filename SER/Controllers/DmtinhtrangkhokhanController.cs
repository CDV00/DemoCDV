﻿using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DmtinhtrangkhokhanController : DanhMucController<Dmtinhtrangkhokhan>
    {
        public DmtinhtrangkhokhanController(IDanhMucService<Dmtinhtrangkhokhan> service) : base(service)
        {
        }
    }
    

}
