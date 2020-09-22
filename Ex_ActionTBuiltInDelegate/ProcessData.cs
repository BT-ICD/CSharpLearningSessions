using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_ActionTBuiltInDelegate
{
    public class ProcessData
    {
        //Last argument action encapsulate method which has two parameter and does not return a value
        public void ProcessAction(int x , int y, Action<int, int> action)
        {
            action(x, y);
            Console.WriteLine("Action has been processed");
        }
    }
}
