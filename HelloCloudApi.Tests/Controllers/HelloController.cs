using Microsoft.AspNetCore.Mvc;

namespace HelloCloudApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from the Cloud!" });
        }
    }
}
