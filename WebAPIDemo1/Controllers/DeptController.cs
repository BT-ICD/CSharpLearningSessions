using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo1.Data;

namespace WebAPIDemo1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeptController : ControllerBase
    {
        private readonly LearningDbContext learningDbContext;

        public DeptController(LearningDbContext learningDbContext )
        {
            this.learningDbContext = learningDbContext;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var result = learningDbContext.Depts.ToList();
            return Ok(result);
        }
    }
}
