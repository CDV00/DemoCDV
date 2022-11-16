using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DmBuocPhongbanxulyController :DanhMucController<DmBuocPhongbanxuly>
    {
        public DmBuocPhongbanxulyController(IDanhMucService<DmBuocPhongbanxuly> service) : base(service)
        {
        }
    }
}
