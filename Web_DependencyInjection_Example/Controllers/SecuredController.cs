using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_DependencyInjection_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SecuredController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            return Ok("Thanks ");
        }
    }
}
