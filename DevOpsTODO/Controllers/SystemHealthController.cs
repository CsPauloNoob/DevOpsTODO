using Microsoft.AspNetCore.Mvc;

namespace DevOpsTODO.Controllers
{
    [ApiController]
    [Route("system")]
    public class SystemHealthController : ControllerBase
    {

        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok(new { status = "API online" });
        }


        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("pong");
        }

    }
}
