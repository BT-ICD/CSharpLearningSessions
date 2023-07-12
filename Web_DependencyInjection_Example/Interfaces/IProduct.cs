using Web_DependencyInjection_Example.Models;

namespace Web_DependencyInjection_Example.Interfaces
{
    public  interface IProduct
    {
        List<Product> GetAll();
        Product GetById(int Id);

    }
}
