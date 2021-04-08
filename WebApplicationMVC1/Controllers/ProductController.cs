using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC1.Models;

namespace WebApplicationMVC1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var list = Product.List();
            return View(list);
        }
        public IActionResult ListWithImages()
        {
            var list = Product.List();
            return View(list);
        }
        public IActionResult Find()
        {
            return View("FindProduct");
        }
        /// <summary>
        /// This method Display is acccesible as a get when we cal lfrom url with query string parameter
        /// THis method Display is also accessible as a HTTPPost call when we Submit Form. Value of ProductId is accessible due to form paramter
        /// Information is sent to the server as a form field value
        /// References: 
        /// https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-5.0
        /// https://developer.mozilla.org/en-US/docs/Learn/Forms/Sending_and_retrieving_form_data
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public IActionResult Display(int ProductId)
        {
            var result = Product.List().Where(p => p.Id == ProductId).FirstOrDefault();
            return View("View",result);
        }
    }
}
