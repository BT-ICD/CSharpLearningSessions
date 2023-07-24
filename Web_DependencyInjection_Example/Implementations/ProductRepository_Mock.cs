using Web_DependencyInjection_Example.Interfaces;
using Web_DependencyInjection_Example.Models;

namespace Web_DependencyInjection_Example.Implementations
{
    public class ProductRepository_Mock: IProduct
    {
        static List<Product> products = new List<Product>()
        {
            new Product(){Id=101,Name="Dettol", Rate=20},
            new Product(){Id=102,Name="Hamam", Rate=30},
            new Product(){Id=103,Name="Cinthol", Rate=40},
        };

        public Product AddNew(Product product)
        {
            //var len = products.Count;
            product.Id = products.Count;
            products.Add(product);
            return product;
        }

        public List<Product> GetAll() => products;
        public Product GetById(int Id) => products.Where(x => x.Id == Id).FirstOrDefault();
    }
}
