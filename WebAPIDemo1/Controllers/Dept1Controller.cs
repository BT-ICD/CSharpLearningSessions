using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo1.Repository;

namespace WebAPIDemo1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Dept1Controller : ControllerBase
    {
        //private readonly IDept dept;

        //public Dept1Controller(IDept dept)
        //{
        //    this.dept = dept;
        //}
        private readonly DeptRepo  dept;
        public Dept1Controller(DeptRepo dept)
        {
            this.dept = dept;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var result = dept.GetList();
            return Ok(result);
        }
    }
}
