using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Rate { get; set; }
        public string ImageName { get; set; }

        public static List<Product> List()
        {
            List<Product> result = new List<Product>()
            {
                new Product(){Id=101,Name="Dettol", Category="A", Rate=40, ImageName="DettolOriginalSoap.jpg"},
                new Product(){Id=102,Name="Cinthol Lime", Category="B", Rate=20,ImageName="CintholLime.jpg"},
                new Product(){Id=103,Name="Dettol Liquid", Category="C", Rate=50, ImageName="DettolAntisepticLiquid.jpg"},
                new Product(){Id=104,Name="Dove", Category="A", Rate=30, ImageName="Dove.jpg"},
                new Product(){Id=105,Name="Cinthol", Category="A", Rate=70,ImageName="Cinthol.jpg"},

            };
            return result;
        }

    }
}
