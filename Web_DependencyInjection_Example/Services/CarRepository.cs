using Web_DependencyInjection_Example.Models;

namespace Web_DependencyInjection_Example.Services
{
    public class CarRepository
    {
        public List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car(){Id=101,Name="Maruti Baleno"},
                new Car(){Id=102,Name="Tata Safari"},
                new Car(){Id=103,Name="Tata Nano"}
            };
        }
    }
}
