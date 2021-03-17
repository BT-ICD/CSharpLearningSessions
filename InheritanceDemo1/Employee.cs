using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string notes;

    }
    public class Salesman:Employee
    {
        public int TA;
        public int DA { get; set; }
        public void DoSalesman()
        {

        }
    }
}
