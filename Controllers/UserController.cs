using Microsoft.AspNetCore.Mvc;

namespace dotnet_sample.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController() { }

        [HttpGet("")]
        public IActionResult GetUser()
        {
            return Ok("Successfully get user");
        }

        [HttpGet("check")]
        public IActionResult check()
        {
            return Ok("check user controller and its endpoint");
        }

        [HttpGet("s")]
        public IActionResult s()
        {
            return Ok("S user controller and its endpoint");
        }
    }
}
