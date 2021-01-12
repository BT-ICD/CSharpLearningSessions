using System;

namespace Ex_UserDefinedClass01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student obj = new Student();

            obj.name = "Rajesh";
            obj.marks = 20;
            Console.WriteLine("Name: " + obj.name);
            Console.WriteLine("Marks: " + obj.marks);

            string fullName = "Rajesh B Shah";
            string[] names = SplitName(fullName);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
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
