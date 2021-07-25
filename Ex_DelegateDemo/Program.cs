using System;

namespace Ex_DelegateDemo
{
    /// <summary>
    /// To learn about delegate
    /// Referencs: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates
    /// </summary>
    class Program
    {
        public delegate void Del(string message);
        public delegate int Calculation(int m, int n);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Instantiate the Delegate
            Del handler = DelegateMethod;
            // Call the delegate.
            handler("Hello from DelegateMethod");

            handler = DelegateMethod2;
            handler("Rajesh");

            Calculation handleCalculation = Addition;
            int result = handleCalculation(10, 20);
            Console.WriteLine($"Addition is {result}");

            //Implementation of delegate as a callback
            handler = DelegateMethod;
            MethodWithCallback(100, 200, handler);

            //Expression-bodied Method example to run
            Person p = new Person("Rajesh", "Shah");
            Console.WriteLine(p);
            p.DisplayName();

            



        }
        /// <summary>
        /// Create a method for delegate
        /// </summary>
        /// <param name="message"></param>
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        public static void DelegateMethod2(string name)
        {
            Console.WriteLine($"Name is {name}");
        }

        /// <summary>
        /// Example of Expression body definition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Addition(int a, int b) => a + b;

        //Delegate as callback method
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback($"The number is: {(param1 + param2).ToString()}");
        }
    }
}
