using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_DependencyInjection_Example.Interfaces;

namespace Web_DependencyInjection_Example.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMessageWriter messageWriter;

        public ProductController(IMessageWriter messageWriter)
        {
            this.messageWriter = messageWriter;
        }
        [HttpGet]
        [Route("{firstName}")]
        public IActionResult Greetings(string firstName)
        {
          

            messageWriter.WriteMessage(firstName);
            var result = new { greetings = $"Hello, {firstName} " };
            return Ok(result);
        }

    }
}
