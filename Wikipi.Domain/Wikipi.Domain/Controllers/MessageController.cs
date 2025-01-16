using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wikipi.Domain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public async Task<int> GetAlertCount()
        {
            Random rnd = new Random();
            var count = rnd.Next(1, 150);
            return await Task.FromResult(count);
        }
    }
}
