using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo1.Models;
using WebAPIDemo1.Repository;

namespace WebAPIDemo1.Controllers
{
    /// <summary>
    /// Learning reference: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-5.0#verb
    /// Static Constructor: Static Constructors (C# Programming Guide) - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        /// <summary>
        /// To get list of products
        /// </summary>
        /// <returns></returns>
        /// Sample Call: https://localhost:44389/api/Product
        [HttpGet]
        public IActionResult List()
        {
            var result = ProductRepository.GetProducts();
            return Ok(result);
        }
        /// <summary>
        /// To get product by name. Using string as route parameter
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// Sample call: https://localhost:44389/api/Product/Cinthol
        [HttpGet("{productName}")]
        public IActionResult Get(string productName)
        {
            var result = ProductRepository.GetProducts().Where(obj => obj.Name == productName).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }
        /// <summary>
        /// Id as a route parameter. To get particular product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// Sample call: https://localhost:44389/api/Product/101
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var result = ProductRepository.GetProducts().Where(obj=>obj.Id==id).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        /// <summary>
        /// To get by rate. Second method to get data by int parameter.  
        /// Added byrate in url to define access by rate
        /// </summary>
        /// <param name="rate"></param>
        /// <returns></returns>
        /// Sample call: https://localhost:44389/api/Product/byrate/50
        [HttpGet("byrate/{rate}")]
        public IActionResult GetByRate(int rate)
        {
            var result = ProductRepository.GetProducts().Where(obj => obj.Rate == rate).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }
        /// <summary>
        /// To add new product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add(Product product)
        {
            var list = ProductRepository.GetProducts();
            list.Add(product);
            var result = list.Where(obj => obj.Id == product.Id);
            //return Ok(result);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, result);

        }
        /// <summary>
        /// To update existing product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, Product product)
        {
            var list = ProductRepository.GetProducts();
            var data = list.Where(obj => obj.Id == id).FirstOrDefault();
            if (data == null)
            {
                return NotFound();
            }
            data.Name = product.Name;
            data.Rate = product.Rate;
            return NoContent();
        }
        /// <summary>
        /// To delete existing product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            var list = ProductRepository.GetProducts();
            var data = list.Where(obj => obj.Id == id).FirstOrDefault();
            if (data == null)
            {
                return NotFound();
            }
            list.Remove(data);
            return NoContent();
        }
        [HttpGet]
        public IActionResult GetProduct([FromQuery] int id)
        {
            var result = ProductRepository.GetProducts().Where(obj => obj.Id == id).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
