using CoreWebApp_MVC_Demo1.Data;
using CoreWebApp_MVC_Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace CoreWebApp_MVC_Demo1.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext appDbContext;
        private readonly IMemoryCache memoryCache;

        public StudentController(AppDbContext appDbContext, IMemoryCache memoryCache)
        {
            this.appDbContext = appDbContext;
            this.memoryCache = memoryCache;
        }
        public IActionResult Index()
        {
            //var data = Student.GetData();
            List<Student> data;
            var isAvailableInCache  = memoryCache.TryGetValue("studentlist", out data);
            if (isAvailableInCache)
            {

                Console.WriteLine("From Cache");
                return View(data);
            }
            else
            {
                
                var cachedEntryOptions = new MemoryCacheEntryOptions()
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(2)
                };
                data = appDbContext.Students.ToList();
                memoryCache.Set("studentlist", data, cachedEntryOptions);
            }
            Console.WriteLine("From DB");
            return View(data);
        }
    }
}
