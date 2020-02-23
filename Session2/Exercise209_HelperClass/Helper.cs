using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise209_HelperClass
{
    public static class Helper
    {


        public static int AddNumbers(this int num1, int num2)
        {
            return num1 + num2;
        }

        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static int Parse(this string str)
        {
            return Int32.Parse(str);
        }


    }
}
