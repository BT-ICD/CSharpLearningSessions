using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_ExtensionMethod
{
    public static class MyIntegerExtensionMethods
    {
        public static bool IsGreaterThan(this int a, int value)
        {
            return a > value;
        }
    }
}
