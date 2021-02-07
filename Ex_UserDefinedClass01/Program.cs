using System;

namespace Ex_UserDefinedClass01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example of params to pass variable number of arguments
            int sum = addition(10, 20,30);
            Console.WriteLine($"Sum of values: {sum}");
            //Example of Expression Bodied Members
            //MyTime t1 = new MyTime();
            //t1.Minutes = 1;
            //t1.Seconds = 20;
            //int totalSeconds = t1.GetTimeInSeconds();
            //Console.WriteLine($"Total seconds of time t1 is: {totalSeconds}");

            //SquareVer1 s1 = new SquareVer1();
            //s1.length = 10;
            //int area = s1.Area();
            //Console.WriteLine($"Area is {area}");


            //First Demo of User Defined class 
            //Console.WriteLine("Hello World!");
            //Student obj = new Student();

            //obj.name = "Rajesh";
            //obj.marks = 20;
            //Console.WriteLine("Name: " + obj.name);
            //Console.WriteLine("Marks: " + obj.marks);

            //Split Function Demo
            //string fullName = "Rajesh B Shah";
            //string[] names = SplitName(fullName);
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
        }
        /// <summary>
        /// Example of params to get variable number of arguments
        /// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        static int addition(params int[] values)
        {
            int result = 0;
            foreach(var data in values)
            {
                result += data;
            }
            return result;
        }
        /// <summary>
        /// To get first Name, Middle Name and Last Name as an array of string
        /// Demo - To learn function which returns an array
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        static string[] SplitName(String fullName)
        {
            return fullName.Split(' ');
        }
    }
}
