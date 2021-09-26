using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        /// <summary>
        /// To get list of products
        /// </summary>
        /// <returns></returns>
        //public static List<Product> GetProductList()
        //{
        //    var result = new List<Product>()
        //    {
        //        new Product(){Id=101,Name="Dettol", Rate=30},
        //        new Product(){Id=102,Name="Cinthol", Rate=80},
        //        new Product(){Id=103,Name="Pears", Rate=50},
        //        new Product(){Id=104,Name="Dove", Rate=20},
        //    };
        //    return result;
        //}
    }
}
