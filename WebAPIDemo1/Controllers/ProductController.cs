using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo1.Models;

namespace WebAPIDemo1.Controllers
{
    /// <summary>
    /// Learning reference: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-5.0#verb
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
            var result = Product.GetProductList();
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
            var result = Product.GetProductList().Where(obj => obj.Name == productName).FirstOrDefault();
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
            var result = Product.GetProductList().Where(obj=>obj.Id==id).FirstOrDefault();
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
            var result = Product.GetProductList().Where(obj => obj.Rate == rate).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }
    }
}
