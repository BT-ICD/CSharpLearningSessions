using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_FuncBuiltInDelegate
{
    /// <summary>
    /// Learning - Example of built in Delegate Func<T,TResult>
    /// Encapsulates a method that has one parameter and returns a value of the type specified 
    /// by the TResult parameter.
    /// References:
    /// https://docs.microsoft.com/en-us/dotnet/api/system.func-2?view=netcore-3.1
    /// https://app.pluralsight.com/course-player?clipId=d61c8851-e41a-460f-8cca-539785d7143a
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning - Func<T,TResult> Delegate");
            Console.WriteLine("Encapsulates a method that has one parameter and returns a value of the type specified by the TResult parameter.");

            //Declare a Func variable and assign a lambda expression to the variable
            //Method takes a string and converts it to upper case
            Func<string, string> selector = str => str.ToUpper();

            //with function body of labmda function to understand it will call this method for each element of array of words
            //Func<string, string> selector = str => {
            //    Console.WriteLine(str + str.Length);
            //    return str.ToUpper();
            //};

            string[] words = { "orange", "apple", "pineapple", "Elephant", "strawberry" };
            IEnumerable<String> awords = words.Select(selector);
            Console.WriteLine("Traverse all the elements of IEnumerable of awords");
            foreach (String word in awords)
            {
                Console.WriteLine(word);
            }

            //Example to create custom delegate using Func Delegate
            Func<int, int, int> funcAddDel = (x, y) => x + y;

            ProcessData data = new ProcessData();
            data.ProcessFunc(2, 3, funcAddDel);


            //Example of LINQ query Method - Where - It uses Func
            List<Student> students = new List<Student>()
            {
                new Student(){Id=101, Name="Rajesh", Grade="A"},
                new Student(){Id=102,Name="Manan", Grade="B"},
                new Student(){Id=103, Name="Kishan",Grade="A"},
                new Student(){Id=104,Name="Kirti",Grade="B"},
                new Student(){Id=105, Name="Krina",Grade="A"}
            };
            var resultStudents = students.Where(s => s.Grade == "A");
            foreach (var item in resultStudents)
            {
                Console.WriteLine(item.Name + " - " + item.Grade);
            }



        }
    }
}
