using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inta.ERP.Resource.Controllers
{
    [Route("api/[controller]")]
    
    [ApiController]
    public class DataEventRecordsController : ControllerBase
    {
        public DataEventRecordsController( )
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
