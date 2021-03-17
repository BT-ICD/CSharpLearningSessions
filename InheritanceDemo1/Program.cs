using System;
using System.Reflection;

namespace InheritanceDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Salesman s = new Salesman() { Id = 101, Name = "Manan", DA = 100, TA=500 };
            Employee e = s;
            
            Type t= typeof(Employee);
            MemberInfo[] members = t.GetMembers();
            foreach (var item in members)
            {
                Console.WriteLine($"{item.Name } - {item.MemberType}");
            }
           
            Console.WriteLine("___________________________________________");
        }
    }
}
