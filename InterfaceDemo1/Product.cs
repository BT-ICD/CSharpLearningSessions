using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo1
{
    public class Product : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }

        public int CompareTo(object obj)
        {
            var productType = typeof(Product);
            if (productType.IsInstanceOfType(obj))
            {
                Product otherProduct = obj as Product;
                return (this.Rate - otherProduct.Rate);
            }
            return 1;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Rate: {Rate}";
        }
    }
}
