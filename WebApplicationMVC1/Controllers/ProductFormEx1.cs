using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC1.Models;

namespace WebApplicationMVC1.Controllers
{
    public class ProductFormEx1 : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Method to access form data as an object when user submit form
        /// </summary>
        /// <param name="objData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(Product objData)
        {

            return View("Detail", objData);
        }
        /// <summary>
        /// Access Form Values as individual parameter when user submit form
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="Rate"></param>
        /// <param name="Category"></param>
        /// <returns></returns>
        //[HttpPost]
        //public IActionResult Index(int Id, String Name, int Rate, String Category)
        //{
        //    Product objData = new Product() { Id = Id, Name = Name , Rate=Rate, Category=Category};

        //    return View("Detail", objData);
        //}





    }
}
