using System;

namespace Ex_ExtensionMethod
{
    class Program
    {
        /// <summary>
        /// Learning - Extension Method
        /// References https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
        /// Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Learning - Extension Method");
            string strData = "Hello, From String Data. Extension methods demo";
            int count = strData.WordCount();
            Console.WriteLine("strData contains " + count + " Words.");

            int discount = 10;
            bool result = discount.IsGreaterThan(50);
            Console.WriteLine("Discount is Greater Than 50: " + result);

        }
    }
}
