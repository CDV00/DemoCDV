using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DmBuocTinhtrangchusohuuController : DanhMucController<DmBuocTinhtrangchusohuu>
    {
        public DmBuocTinhtrangchusohuuController(IDanhMucService<DmBuocTinhtrangchusohuu> service) : base(service)
        {
        }
    }

}
