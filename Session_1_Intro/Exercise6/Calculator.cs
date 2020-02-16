using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise6
{
    namespace DNP
    {
        namespace MathLib
        {
            class Calculator
            {
                public int Add(int a, int b)
                {
                    return a + b;
                }

                public int Add(int[] array)
                {
                    return array.Sum();
                }
            }
        }
    }
    

}
