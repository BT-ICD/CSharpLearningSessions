using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Web_DependencyInjection_Example.Helper;

namespace Web_DependencyInjection_Example.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OptionPatternDemoController : ControllerBase
    {
        //Refernces: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-7.0
        private readonly IConfiguration configuration;
        private readonly PositionOptions position;

        public OptionPatternDemoController(IConfiguration configuration, IOptions<PositionOptions> position)
        {
            this.configuration = configuration;
            this.position = position.Value;
            
        }
        [HttpGet]
        public IActionResult GetPositionUsingConfiguration()
        {
            var positionOptions = new PositionOptions();
            configuration.GetSection(PositionOptions.Position).Bind(positionOptions);
            return Content($"Title: {positionOptions.Title} , Name: {positionOptions.Name}");
        }
        [HttpGet]
        public IActionResult GetPositonDetailsWithDI()
        {
            return Content($"Title: {position.Title} , Name: {position.Name}");

        }

    }
}
