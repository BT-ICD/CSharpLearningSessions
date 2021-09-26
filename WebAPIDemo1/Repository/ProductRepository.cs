using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo1.Models;

namespace WebAPIDemo1.Repository
{
    public class ProductRepository
    {
        static List<Product> products;
        static ProductRepository()
        {
            products = new List<Product>()
            {
                new Product(){Id=101,Name="Dettol", Rate=30},
                new Product(){Id=102,Name="Cinthol", Rate=80},
                new Product(){Id=103,Name="Pears", Rate=50},
                new Product(){Id=104,Name="Dove", Rate=20},
            };
        }
        public static List<Product> GetProducts()
        {
            return products;
        }
    }
}
