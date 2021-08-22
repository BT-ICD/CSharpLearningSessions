using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Collection_LINQ
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name} Rate:{Rate}" ;
        }
        public static Product[] GetProductsArray()
        {
            Product[] products = new Product[3];
            products[0] = new Product() { Id = 101, Name = "Dettol", Rate = 30 };
            products[1] = new Product() { Id = 103, Name = "Cinthol", Rate = 10 };
            products[2] = new Product() { Id = 102, Name = "Hamam", Rate = 40 };
            return products;
        }
    }
}
