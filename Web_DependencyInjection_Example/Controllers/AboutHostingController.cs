using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_DependencyInjection_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutHostingController : ControllerBase
    {
        private readonly IHostEnvironment hostEnvironment;

        public AboutHostingController(IHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }
        [HttpGet]
        public IActionResult GetHostingParams()
        {
            var r1 = hostEnvironment.ApplicationName;
            var r2 = hostEnvironment.IsProduction().ToString();
            var r3 = hostEnvironment.ContentRootPath;
            var r4 = hostEnvironment.EnvironmentName;
            var result = new { ApplicationName = r1 , IsProduction=r2, ContentRootPath =r3, EnvironmentName =r4};
            return Ok(result);


        }
    }
}
