using System;
using Exercise6.DNP.MathLib;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            DNP.MathLib.Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(1,2));

            Console.WriteLine(calc.Add(new []{1,2,3,4}));
        }
    }
}
