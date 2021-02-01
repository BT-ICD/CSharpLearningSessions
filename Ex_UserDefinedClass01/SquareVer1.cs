using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_UserDefinedClass01
{
    class SquareVer1
    {
        public int length;
        public int Area()
        {
            return length * length;
        }
        public int Perimeter()
        {
            return 4 * length;
        }
    }
}
