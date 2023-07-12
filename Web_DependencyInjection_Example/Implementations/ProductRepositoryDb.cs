using Web_DependencyInjection_Example.Data;
using Web_DependencyInjection_Example.Interfaces;
using Web_DependencyInjection_Example.Models;

namespace Web_DependencyInjection_Example.Implementations
{
    public class ProductRepositoryDb : IProduct
    {
        private readonly AppDbContext appDbContext;
        public ProductRepositoryDb(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List<Product> GetAll()=> appDbContext.Products.ToList();
        public Product GetById(int Id)=> appDbContext.Products.Where(x => x.Id == Id).FirstOrDefault();
        
    }
}
