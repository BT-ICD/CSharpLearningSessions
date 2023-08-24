using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_DependencyInjection_Example.Models;

namespace Web_DependencyInjection_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Employee employee = new Employee() { Id=101,Name="Rajesh",Designation="Project Manager", Salary=100000};
            Console.WriteLine(employee);
            return Ok(employee);
        }
    }
}
