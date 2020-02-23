using System.Linq;

namespace Exercise106
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
