using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_FuncBuiltInDelegate
{
    public class ProcessData
    {
        //Last argument action encapsulate method which has two parameter and return a value
        public void ProcessFunc(int x, int y, Func<int, int, int> action)
        {
            var result = action(x, y);
            Console.WriteLine("Action has been processed answer is " + result);
        }
    }
}
