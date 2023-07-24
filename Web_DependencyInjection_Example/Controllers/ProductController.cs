using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_DependencyInjection_Example.Interfaces;
using Web_DependencyInjection_Example.Models;

namespace Web_DependencyInjection_Example.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMessageWriter messageWriter;
        private readonly IProduct product;
        private readonly IMapper mapper;

        public ProductController(IMessageWriter messageWriter, IProduct product, IMapper mapper)
        {
            this.messageWriter = messageWriter;
            this.product = product;
            this.mapper = mapper;
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
        [HttpPost]
        public IActionResult Add(ProductDTOAdd productDTOAdd)
        {
            //Product p1 = new Product();

            Product p1 = mapper.Map<Product>(productDTOAdd);
            
            var result = product.AddNew(p1);
            return Ok(result);

        }
        
    }
}
