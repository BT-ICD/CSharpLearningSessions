using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_UserDefinedClass01
{
    public class MyTime
    {
        public int Seconds { get; set; }
        public int Minutes { get; set; }

        /// <summary>
        /// Example of Expression Bodied Members
        /// Reference - https://docs.microsoft.com/en-us/dotnet/csharp/methods#expression-bodied-members
        /// </summary>
        /// <returns></returns>
        public int GetTimeInSeconds() => ((Minutes * 60) + Seconds);
             
    }
}
