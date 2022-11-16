using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DmquytrinhController : DanhMucController<Dmquytrinh>
    {
        public DmquytrinhController(IDanhMucService<Dmquytrinh> service) : base(service)
        {
        }
    }

}
