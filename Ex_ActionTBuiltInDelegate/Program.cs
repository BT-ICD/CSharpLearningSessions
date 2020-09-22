using System;
using System.Collections.Generic;
using System.Windows;
namespace Ex_ActionTBuiltInDelegate
{
    /// <summary>
    /// Example - Action <T> Delegate - Built in Delegate 
    /// Delegate which encapsulates a method
    /// References: 
    /// C# Events, Delegates and Lambdas-By Dan Wahlin Pluralsight
    /// https://docs.microsoft.com/en-us/dotnet/api/system.action-1?view=netcore-3.1
    /// </summary>
    class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Learning - Action<T> Delegate");

            ProcessData data = new ProcessData();
            //define action with two integeres
            //addAction points to the function which performs addition of two integers and display output on console window
            Action<int, int> addAction = (x, y) => Console.WriteLine("Sum of " + x + ", " +  y + " is: " + (x + y));
            Action<int, int> multiplyAction = (x, y) => Console.WriteLine("Multiplication of " + x + "," + y + " is:" + (x * y));
            
            //Invoke Action
            data.ProcessAction(10, 20, addAction);
            data.ProcessAction(10, 20, multiplyAction);


            //When you use the Action<T> delegate, you do not have to explicitly define a delegate that encapsulates a method with a single parameter.
            //For Example, the following code explicitly declares a delegate name Display message and assigns a reference to either the WriteLine method or the ShowWindowMessage method to its delegate instance

            Action<string> messageTarget;
            if (Environment.GetCommandLineArgs().Length > 1)
                messageTarget = Console.WriteLine;
            else
                messageTarget = ShowFormattedMessage;

            //To Invoke method using lambda expression
            //if (Environment.GetCommandLineArgs().Length > 1)
            //    messageTarget = (s)=> Console.WriteLine(s);
            //else
            //    messageTarget = (s) =>ShowFormattedMessage(s);

            //Invoke method on which message Target Handle points to 
            messageTarget("Hello to Action Delegates ....");


            Console.WriteLine("Example of built it List<T>.ForEach(Action<T>) Method ");

            //Example of Built in - List<T>.ForEach(Action<T>) Method
            //Performs the specified action on each element of the List<T>.
            List<string> names = new List<string>();
            names.Add("Rajesh");
            names.Add("Manan");
            names.Add("Vrunda");

            //Console.WriteLine method passed as an argumet - we can pass any other method which has one argument and does not return anything
            names.ForEach(Console.WriteLine);

            //ShowFormattedMessage passed as an argument
            names.ForEach(ShowFormattedMessage);

            //Remarks
            //The Action<T> is a delegate to a method that performs an action on the object passed to it. The elements of the current List<T> are individually passed to the Action< T > delegate.

        }
        private static void ShowFormattedMessage(string message)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Formatted Message is : " + message);
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
