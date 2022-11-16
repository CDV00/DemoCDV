using Microsoft.AspNetCore.Mvc;
using SER.Domain.Models;
using SER.Domain.Services;
using SER.Infrastructure.ViewModel.KhoKhan;

namespace SER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoKhanController : CRUDController<Khokhan, KhoKhanReponse, KhoKhanResquest>
    {

        public KhoKhanController(IBaseService<Khokhan, KhoKhanReponse, KhoKhanResquest> service) : base(service)
        {
        }
    }


}
