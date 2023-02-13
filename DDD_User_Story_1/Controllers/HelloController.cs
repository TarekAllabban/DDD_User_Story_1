using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD_User_Story_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet(Name = "GetHello")]
        public async Task<String> Get()
        {
            return "Hello World!";
        }
    }
}
