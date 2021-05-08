using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC1.DataContext;
using WebApplicationMVC1.Entities;

namespace WebApplicationMVC1.Controllers
{
    public class DeptController : Controller
    {
        public IActionResult Index()
        {
            List<DEPT> result;
            using (var db = new MyAppDbContext())
            {
                result = db.Depts.ToList();
            }
            return View(result);
        }
    }
}
