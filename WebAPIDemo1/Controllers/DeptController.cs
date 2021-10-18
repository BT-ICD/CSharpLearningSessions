using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo1.Data;
using WebAPIDemo1.Models;

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
        [HttpGet]
        [Route("{Deptno:int}")]
        public IActionResult GetById(int Deptno)
        {
            var result = learningDbContext.Depts.Where(obj => obj.Deptno == Deptno).FirstOrDefault();
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(Dept dept)
        {
            var result = learningDbContext.Depts.Add(dept);
            var afffectedRecords = learningDbContext.SaveChanges();
            var ans = learningDbContext.Depts.Where(o => o.Deptno == dept.Deptno).FirstOrDefault();
            //return Ok(ans);
            //return CreatedAtAction("GetById", new { Deptno = ans.Deptno}, ans);
            return CreatedAtAction(nameof(GetById), new { Deptno = ans.Deptno }, ans);

        }
    }
}
