using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC1.Models;

namespace WebApplicationMVC1.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            List<SelectListItem> suffixListItems = new List<SelectListItem>()
            {
                new SelectListItem(){Text="Mr", Value="1"},
                new SelectListItem(){Text="Master", Value="2", Selected=true},
                new SelectListItem(){Text="Miss", Value="3"},
                new SelectListItem(){Text="Mrs", Value="4"}
            };
            ViewBag.suffixListItems = suffixListItems;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee employee)
        {
            IEnumerable<SelectListItem> suffixListItems = new List<SelectListItem>()
            {
                new SelectListItem(){Text="Mr", Value="1"},
                new SelectListItem(){Text="Master", Value="2", Selected=true},
                new SelectListItem(){Text="Miss", Value="3"},
                new SelectListItem(){Text="Mrs", Value="4"}
            };
            ViewBag.suffixListItems = suffixListItems;
            Employee obj = employee;
            return View();
        }

    }
}
