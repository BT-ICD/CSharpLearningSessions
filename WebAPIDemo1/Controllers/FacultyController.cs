using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo1.Models;

namespace WebAPIDemo1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add([FromForm] Faculty faculty)
        {
            var locationToSaveFile = Path.Combine(AppContext.BaseDirectory, "Documents", faculty.ImageFile.FileName);

            //document will stored under bin\debug\netcoreapp3.1\documents
            var data = faculty;
            using(FileStream stream = System.IO.File.Create(locationToSaveFile))
            {
                faculty.ImageFile.CopyTo(stream);
            }
            return Ok();
        }
    }
   
}
