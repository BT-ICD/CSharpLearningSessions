using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC1.Models;

namespace WebApplicationMVC1.Controllers
{
    public class RazorDemoController : Controller
    {
        //ViewData Attribute = Properties on controllers or Razor Page models marked with the [ViewData] attribute have their values stored and loaded from the dictionary.
        [ViewData]
        public string MessageData { get; set; }
        /// <summary>
        /// To understand and learn about Razor syntax
        /// Learning reference: https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-5.0
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Method with argument where user can pass data using query string
        /// View can access value using viewData
        /// </summary>
        /// <param name="numTimes"></param>
        /// <returns></returns>
        public IActionResult Names(string name, int numTimes)
        {
            Address address = new Address() { Area = "Naranpura", City = "Ahmedabad", State = "Gujarat" };
            MessageData = "Hello World, thanks to ViewData attribute";
            ViewData["numTimes"] = numTimes;
            ViewData.Add("name", name);
            ViewData["address"] = address;
            return View();
        }
    }
}
