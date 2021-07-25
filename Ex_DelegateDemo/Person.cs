using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_DelegateDemo
{
    /// <summary>
    /// Example: Expression-bodied method
    /// Learning Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
    /// </summary>
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
        }

        private string fname;
        private string lname;

        public override string ToString() => $"{fname} {lname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());
    }
}
