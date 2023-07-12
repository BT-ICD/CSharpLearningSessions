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
        private readonly IProduct product;

        public ProductController(IMessageWriter messageWriter, IProduct product)
        {
            this.messageWriter = messageWriter;
            this.product = product;
        }
        [HttpGet]
        [Route("{firstName}")]
        public IActionResult Greetings(string firstName)
        {
          

            messageWriter.WriteMessage(firstName);
            var result = new { greetings = $"Hello, {firstName} " };
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(product.GetAll());
        }
        [HttpGet]
        [Route("{Id:int}")]
        public IActionResult GetById(int Id)
        {
            return Ok(product.GetById(Id));
        }

    }
}
