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
        [HttpPost]
        public IActionResult Index(int Id, String Name, int Rate, String Category)
        {
            Product objData = new Product() { Id = Id, Name = Name , Rate=Rate, Category=Category};
            return View();
        }
    }
}
