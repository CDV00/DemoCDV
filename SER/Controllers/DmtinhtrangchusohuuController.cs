using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DmtinhtrangchusohuuController : DanhMucController<Dmtinhtrangchusohuu>
    {
        public DmtinhtrangchusohuuController(IDanhMucService<Dmtinhtrangchusohuu> service) : base(service)
        {
        }
    }
    

}
