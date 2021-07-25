using System;
using System.Collections.Generic;

namespace Ex_Collection_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection Examples");
            //Example1();
            //ExampleCollectionInitializer();
            ExampleCollectionUsingIndex();

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
    }
}
