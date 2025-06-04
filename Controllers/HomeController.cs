using Microsoft.AspNetCore.Mvc;

namespace dotnet_sample.Controllers
{
    [ApiController]
    [Route("api/")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok("Welcome to dotnet sample API");
        }

        [HttpGet("GetData")]
        public IActionResult GetData()
        {
            return Ok("GetData dotnet sample API");
        }

    }
}
