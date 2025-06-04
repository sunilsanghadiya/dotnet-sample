using Microsoft.AspNetCore.Mvc;

namespace dotnet_sample.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController() { }

        [HttpGet("GetUser")]
        public IActionResult GetUser()
        {
            return Ok("Successfully get user");
        }
    }
}
