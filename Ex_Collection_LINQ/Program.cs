using System;
using System.Collections.Generic;

namespace Ex_Collection_LINQ
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Array Example");
            DictionartDemo1();

            //SortArrayExample1();
            //ArrayFind();
            //SortArrayExample2();


            //Console.WriteLine("Collection Examples");
            //Example1();
            //ExampleCollectionInitializer();
            //ExampleCollectionUsingIndex();
            //Exist method - Example of Exist method of list with Predicate
            //ExampleListExistsToLearnPredicate();
            //Find All method Exaple with Predicate
            //ExampleListFinAll();

        }

        private static void DictionartDemo1()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            data.Add("Ahmdadbad", 10);
            data.Add("Surat", 10);
            data.Add("Valsad", 10);
            foreach (var item in data.Keys)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Simple Collection of String
        /// </summary>
        static void Example1()
        {
            var countries = new List<String>();
            countries.Add("INDIA");
            countries.Add("CANADA");
            countries.Add("UK");

            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }

        }
        /// <summary>
        /// Collection Initializer
        /// </summary>
        static void ExampleCollectionInitializer()
        {
            var countries = new List<String>() { "INDIA", "JAPAN", "USA", "CANADA", "UK" };

            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Access elements of collection using index and traverse using for loop instead of for each loop
        /// </summary>
        static void ExampleCollectionUsingIndex()
        {
            var countries = new List<String>() { "INDIA", "JAPAN", "USA", "CANADA", "UK" };

            for(int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine(countries[i]);
            }
        }

        static void ExampleCollectionObject()
        {
            var products = new List<Product>() {
                new Product { Id=101,Name="Dettol",Rate=30},
                new Product { Id=102,Name="Cinthol",Rate=40},
                new Product { Id=103,Name="Dove",Rate=50},
                new Product { Id=104,Name="Hamam",Rate=20}
            };

        }
        static void ExampleListExistsToLearnPredicate()
        {
            //Learning reference: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.exists?view=net-5.0
            var products = new List<Product>() {
                new Product { Id=101,Name="Dettol",Rate=30},
                new Product { Id=102,Name="Cinthol",Rate=40},
                new Product { Id=103,Name="Dove",Rate=50},
                new Product { Id=104,Name="Hamam",Rate=20}
            };

            Console.WriteLine($"Initial Length of products is  {products.Count}");
            Console.WriteLine("Determine products having rate >20 using exist method");
            var result = products.Exists(obj => obj.Rate > 20);
            Console.WriteLine($"Result: List of products having rate >20 is {result}");
        }
        static void ExampleListFinAll()
        {
            //Learning reference: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.findall?view=net-5.0
            var products = new List<Product>() {
                new Product { Id=101,Name="Dettol",Rate=30},
                new Product { Id=102,Name="Cinthol",Rate=40},
                new Product { Id=103,Name="Dove",Rate=50},
                new Product { Id=104,Name="Hamam",Rate=20}
            };

            Console.WriteLine($"Initial Length of products is  {products.Count}");
            Console.WriteLine("To get list of products having rate >20 using FindAll");
            var result = products.FindAll(obj => obj.Rate > 20);
            Console.WriteLine($"Result: List of products having rate >20 is {result.Count}");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        static void ArrayFind()
        {
            Product[] products = Product.GetProductsArray();
            //Predicate as lambda expression
            //var result = Array.Find(products, obj => obj.Id == 1001);
            //Predicate as deligate
            //var result = Array.Find(products, FindProduct);
            Predicate<Product> predicateFindProduct = FindProduct;
            var result = Array.Find(products, predicateFindProduct);
            if (result==null)
            {
                Console.WriteLine("No Data Found");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
        static bool FindProduct(Product obj)
        {
            return obj.Id == 1002;
        }
        static void SortArrayExample1()
        {
            int[] values = new int[] {10,30,5,20,3 };
            
            Console.WriteLine(values.Length);
            Console.WriteLine("Initial Array Elements");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array Elements After Sorting");
            Array.Sort(values);
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
           

        }
        static void SortArrayExample2()
        {
            Product[] products = Product.GetProductsArray();
            //Prior to sort
            Console.WriteLine("Initial Array Elements");
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Array.Sort(products);
            Console.WriteLine("Array Elements After Sorting");
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
