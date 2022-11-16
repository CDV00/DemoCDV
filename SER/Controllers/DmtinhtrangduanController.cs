using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DmtinhtrangduanController : DanhMucController<Dmtinhtrangduan>
    {
        public DmtinhtrangduanController(IDanhMucService<Dmtinhtrangduan> service) : base(service)
        {
        }
    }
    

}
