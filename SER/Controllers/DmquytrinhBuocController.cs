using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DmquytrinhBuocController : DanhMucController<DmquytrinhBuoc>
    {
        public DmquytrinhBuocController(IDanhMucService<DmquytrinhBuoc> service) : base(service)
        {
        }
    }
    

}
