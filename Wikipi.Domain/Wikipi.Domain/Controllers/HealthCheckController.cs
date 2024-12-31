using Microsoft.AspNetCore.Mvc;

namespace Wikipi.Domain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok();
        }   
    }
}
