using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_ExtensionMethod
{
    public static class MyStringExtensionMethods
    {
        /// <summary>
        /// Custom Extenstion Method used to get number of words in a string. Separated by space or . or ?
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int WordCount(this String str)
        {
            int result = 0;
            result = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return result;
        }
    }
}
