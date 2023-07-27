using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_DependencyInjection_Example.Services;

namespace Web_DependencyInjection_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarRepository carRepository;
        private readonly ILogger<CarController> logger;

        public CarController(CarRepository carRepository, ILogger<CarController> logger)
        {
            this.carRepository = carRepository;
            this.logger = logger;
        }

        //[HttpGet]
        //public IActionResult GetCars() => Ok(this.carRepository.GetCars());
        [HttpGet]
        public IActionResult GetCars()
        {
            logger.LogInformation("Method Name: GetCars Involed By the user");
            return Ok(this.carRepository.GetCars());
        }
    }
}
