using System;

namespace InterfaceDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of IComparable Interface!");
            Product[] products = new Product[4];
            products[0] = new Product() { Id = 101, Name = "Dettol", Rate = 30 };
            products[1] = new Product() { Id = 102, Name = "Cinthol", Rate = 20 };
            products[2] = new Product() { Id = 103, Name = "Hamam", Rate = 10 };
            products[3] = new Product() { Id = 104, Name = "Dove", Rate = 45 };

            //Console.WriteLine(typeof(Product).IsInstanceOfType(p1));
            //Console.WriteLine(typeof(IComparable).IsInstanceOfType(p1));

            //int x = 10;
            //Console.WriteLine(x is int);
            //Console.WriteLine(x is long);
            //Object b1 = new Base();
            //Object d1 = new Derived();
            //Console.WriteLine(b1 is Base);
            //Console.WriteLine(d1 is Derived);
            //Console.WriteLine(b1 is Derived);

            Console.WriteLine("Prior to sort");
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Array.Sort(products);
            Console.WriteLine("After to sort");
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            List<String> names = new List<String>();


        }
        
    }
    class Base
    {

    }
    class Derived : Base
    {

    }
}
