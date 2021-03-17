using System;

namespace InterfaceDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of IComparable Interface!");
            Product p1 = new Product() { Id = 101, Name = "Dettol", Rate = 30 };
            Console.WriteLine(typeof(Product).IsInstanceOfType(p1));
            Console.WriteLine(typeof(IComparable).IsInstanceOfType(p1));

            int x = 10;
            Console.WriteLine(x is int);
            Console.WriteLine(x is long);
            Object b1 = new Base();
            Object d1 = new Derived();
            Console.WriteLine(b1 is Base);
            Console.WriteLine(d1 is Derived);
            Console.WriteLine(b1 is Derived);


        }
        
    }
    class Base
    {

    }
    class Derived : Base
    {

    }
}
