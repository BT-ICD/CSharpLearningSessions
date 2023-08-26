using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//Learning References: Handle errors in ASP.NET Core
//https://learn.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-7.0
namespace Web_DependencyInjection_Example.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DemoErrorController : ControllerBase
    {
        [HttpGet]
        [Route("{a}/{b}")]
        public IActionResult GetData(int a, int b )
        {
            var result = new { answer=a/b };
            return Ok(result);
        }
    }
}
